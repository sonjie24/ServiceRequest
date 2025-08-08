using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AccountManagement.Framework.Core
{
    public class MerchantTokenManager : IMerchantTokenManager<MerchantAccountEntity>
    {
        protected readonly Database database;
        private readonly ILogger ilogger;
        private readonly JwtSettings jwtSettings;
        private readonly TokenValidationParameters tokenValidateParameters;

        public MerchantTokenManager(ILogger<MerchantTokenManager> _logger,
                            JwtSettings _jwtSettings,
                            Database database,
                            TokenValidationParameters _tokenValidateParameters)

        {
            ilogger = _logger;
            this.database = database;
            jwtSettings = _jwtSettings;
            tokenValidateParameters = _tokenValidateParameters;
        }

        public async Task<AuthenticationResult> GenerateAuthenticationAsync(MerchantAccountEntity user)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(jwtSettings.SecretKey);
                //byte[] key = Convert.FromBase64String(jwtSettings.SecretKey);
                SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
                var dt = Common.getDateNow();
                user.MobileNumber = user.MobileNumber==null ? "" : user.MobileNumber ;
                user.EmailAddress = user.EmailAddress==null ? "" : user.EmailAddress ;
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(type: JwtRegisteredClaimNames.Jti, value: user.GUID ),
                        new Claim(type: JwtRegisteredClaimNames.Sub, value:  user.MobileNumber),
                        new Claim(type: JwtRegisteredClaimNames.Email, value: user.EmailAddress),
                        new Claim(type: "id", value: user.GUID),
                        new Claim(type: "userName", value:  ""),
                        new Claim(type: "roledescription", value: "")
                   }),
                    Expires = dt.AddMinutes(jwtSettings.TokenLifeTime),
                    SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature),
                    Issuer = jwtSettings.Issuer,
                    Audience = jwtSettings.Audience,

                };

                var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);
                var refreshToken = new RefreshTokenMerchant
                {
                    JwtId = token.Id,
                    userGuid = user.GUID,
                    Token = Common.NewGUID(),
                    Creation = dt,
                    Expirydate = dt.AddMonths(6)//refresh token expiry
                };

                //save token for later use
                await database.context.RefreshTokenMerchants.AddAsync(refreshToken);
                database.context.SaveChanges();

                return new AuthenticationResult
                {
                    ResultEnum = Result.Success,
                    AccessToken = tokenHandler.WriteToken(token),
                    RefreshToken = refreshToken.Token
                };

            }
            catch (Exception  )
            {
                return null;
            }
        }

        public async Task<ResultViewModel> RefreshTokenAsync(string accessToken, string refreshToken)
        {
            ResultViewModel result = new ResultViewModel();
            result.ResultEnum = Result.Failed.ToString();
            try
            {
                var validateToken = GetPrincipalFromToken(accessToken);
                if (validateToken == null)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "Cannot validate existing token";
                    return result;
                }

                var expiryDateUnix = long.Parse(validateToken.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
                var expiryDateUtC = new DateTime(year: 1970, month: 1, day: 1, hour: 0, minute: 0, second: 0, DateTimeKind.Utc)
                    .AddSeconds(expiryDateUnix);

                if (expiryDateUtC > Common.getDateNow())
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "This token hasn't expired yet.";
                    return result;
                }

                var jti = validateToken.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Jti).Value;
                var storedRefreshToken = await database.context.RefreshTokenMerchants.SingleOrDefaultAsync(predicate: x => x.Token == refreshToken);

                if (storedRefreshToken == null)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "This refresh token does not exist.";
                    return result;
                }
                if (Common.getDateNow() > storedRefreshToken.Expirydate)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "This refresh token has expired";
                    return result;
                }
                if (storedRefreshToken.Invalidated)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "This refresh token has been invalidated.";
                    return result;
                }
                if (storedRefreshToken.Used)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "This refresh token has been used.";
                    return result;
                }
                if (storedRefreshToken.JwtId != jti)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "This refresh token does not match this JWT.";
                    return result;
                }

                //store this to much faster storage?
                storedRefreshToken.Used = true;
                database.context.RefreshTokenMerchants.Update(storedRefreshToken);
                await database.context.SaveChangesAsync();

                string userId = validateToken.Claims.Single(x => x.Type == "id").Value;
                var user = await database.context.MerchantAccounts.SingleOrDefaultAsync(x => x.GUID == userId);

                if (user == null)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "cannot verify user for this token";
                    return result;
                }

                //var tokenAccount = await PopuplateClaims(claimId); 
                AuthenticationResult genToken = await GenerateAuthenticationAsync(user);
                if (genToken == null)
                {
                    result.ResultEnum = Result.Failed.ToString();
                    result.ResultMessage = "Unable to generate token.";
                    return result;
                }

                var data = new
                {
                    AccessToken = genToken.AccessToken,
                    ResfreshToken = genToken.RefreshToken,
                    userId = user.GUID,
                };

                result.ResultEnum = Result.Success.ToString();
                result.ResultMessage = "Successful";
                result.ResultObject = data;
            }
            catch (Exception ex)
            {
                result.ResultEnum = Result.Error.ToString();
                result.ResultMessage = ex.Message;
                ilogger.LogError(ex.Message, ex);
            }
            return result;
        }


        private ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null) return null;
                SecurityToken validatedToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, tokenValidateParameters, out validatedToken);
                if (!IsJwtValidSecurityAlgorithm(validatedToken)) return null;
                return principal;
            }
            catch ( Exception)
            {
                return null;
            }

            //try
            //{
            //    var tokenHandler = new JwtSecurityTokenHandler();
            //    var principal = tokenHandler.ValidateToken(token, tokenValidateParameters, out var validatedToken);
            //    if (!IsJwtValidSecurityAlgorithm(validatedToken))
            //    {
            //        return null;
            //    }
            //    return principal;
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}
        }
        private bool IsJwtValidSecurityAlgorithm(SecurityToken validatedToken)
        {
            return (validatedToken is JwtSecurityToken jwtSecurityToken) && jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);
        }


        //public TokenModel ActivateTokenUsingRefreshToke(TokenModel tokenModel)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var claimsPrincipal = tokenHandler.ValidateToken(tokenModel.Token,
        //    new TokenValidationParameters
        //    {
        //        ValidateIssuer = true,
        //        ValidIssuer = _tokenSettings.Issuer,
        //        ValidateAudience = true,
        //        ValidAudience = _tokenSettings.Audience,
        //        ValidateIssuerSigningKey = true,
        //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenSettings.Key)),
        //        ValidateLifetime = true
        //    }, out SecurityToken validatedToken);

        //    var jwtToken = validatedToken as JwtSecurityToken;

        //    if (jwtToken == null || !jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256))
        //    {
        //        return null;
        //    }

        //    var email = claimsPrincipal.Claims.Where(_ => _.Type == ClaimTypes.Email).Select(_ => _.Value).FirstOrDefault();
        //    if (string.IsNullOrEmpty(email))
        //    {
        //        return null;
        //    }

        //    var currentUser = _myWorldDbContext.User.Where(_ => _.Email == email && _.RefreshToken == tokenModel.RefreshToken).FirstOrDefault();
        //    if (currentUser == null)
        //    {
        //        return null;
        //    }

        //    var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenSettings.Key));
        //    var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        //    var newJwtToken = new JwtSecurityToken(
        //            issuer: _tokenSettings.Issuer,
        //            audience: _tokenSettings.Audience,
        //            expires: DateTime.Now.AddMinutes(20),
        //            signingCredentials: credentials,
        //            claims: jwtToken.Claims
        //    );

        //    string token = new JwtSecurityTokenHandler().WriteToken(newJwtToken);
        //    string refreshToken = GetRefreshToken();

        //    currentUser.RefreshToken = refreshToken;
        //    _myWorldDbContext.SaveChanges();


        //    return new TokenModel
        //    {
        //        Token = token,
        //        RefreshToken = refreshToken
        //    };
        //}

    }
}
