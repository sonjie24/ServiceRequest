using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AccountManagement.Framework.Core 
{
    public sealed class PasswordHasher
    {
        /// <summary>
        ///     Size of salt
        /// </summary>
        private const int SaltSize = 18;

        /// <summary>
        ///     Size of hash
        /// </summary>
        private const int HashSize = 24;

        private static string CreateSecurePassword(string password, byte[] salt, int iterations)
        {
            //Create Hash
            var hash = GenerateHash(password, salt, iterations);

            //Combine Salt and Hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert to Base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            //format hash with extra information
            return string.Format("G30l0g!cH@$H{0}${1}", iterations, base64Hash);
        }

        /// <summary>
        ///     Creates Salt for Password
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            return salt;
        }

        // <summary>
        ///     Generates Password Hash with Salt and Iterations
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="salt">Generated Salt</param>
        /// <param name="iterations">Number of Iterations</param>
        /// <returns>returns the generated hash (pbkdf2)</returns>
        private static byte[] GenerateHash(string password, byte[] salt, int iterations) => new Rfc2898DeriveBytes(password, salt, iterations).GetBytes(HashSize);

        /// <summary>
        ///     Create Hash Password
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="salt">Salt Generated</param>
        /// <returns>returns the hashed password</returns>
        public static string HashPassword(string password, byte[] salt) => CreateSecurePassword(password, salt, 2048);


        /// <summary>
        ///     Check if hash is supported
        /// </summary>
        /// <param name="hashString">Hash</param>
        /// <returns>Returns boolean if the hashed password is supported</returns>
        public static bool IsHashSupported(string hashString) => hashString.Contains("G30l0g!cH@$H");

        /// <summary>
        ///     Verify a password against a hash
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="hashedPassword">Hashed Password</param>
        /// <returns>returns a validated password</returns>
        public static bool Verify(string password, string hashedPassword)
        {
            // Check Hashed Password
            if (!IsHashSupported(hashedPassword))
            {
                return false;
                //throw new NotSupportedException("The hashtype is not supported");
            }

            // Extract Iteration and Base64 String
            var splittedHashString = hashedPassword.Replace("G30l0g!cH@$H", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            // Get Hash Bytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            // Get Salt from the Hash
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Create Hash with Given Salt
            byte[] hash = GenerateHash(password, salt, iterations);

            // Get Result
            for (var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                    return false;
            }

            return true;
        }
    }
}
