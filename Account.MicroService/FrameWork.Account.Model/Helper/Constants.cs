using System;
namespace AccountManagement.Framework.Models
{
    public class Constants
    {
        //Messages

        public const string MESSAGE_ACCOUNT_NOT_EXISTS = "The account does not exist";
        public const string MESSAGE_ACCOUNT_ALREADY_EXISTS= "The account is already exist";
        public const string MESSAGE_ACCOUNT_NOT_ACTIVE= "The account is not active";
        public const string MESSAGE_EMAIL_ALREADY_EXISTS= "The email is already registered.";
        public const string MESSAGE_MOBILE_ALREADY_EXISTS= "The mobile is already registered.";
        public const string MESSAGE_INVALID_RATING= "Invalid Rating";
        public const string MESSAGE_INVALID_EMAIL_ADDRESS= "Invalid email address";
        public const string MESSAGE_INVALID_MOBILE_NUMBER= "Invalid mobile number";
        public const string MESSAGE_INVALID_INPUT= "Invalid user input";
        public const string MESSAGE_INVALID_PASSWORD= "Invalid Credential";
        public const string MESSAGE_INVALID_PASSWORD_LENGTH= "The field password must be a string or array type with a minimum length of '8'";
        public const string MESSAGE_NOT_MATCH_PASSWORD = "The given password does not match";
        public const string MESSAGE_INVALID_SOCIAL_ID = "Invalid social Id";
        public const string MESSAGE_UNABLE_TO_PROCESS_REQUEST= "Unable to process request";
        public const string MESSAGE_EMAIL_NOT_SENT= "Email delivery failure";
        public const string MESSAGE_TOKEN_ERROR = "There is an error in generating token";
        public const string MESSAGE_UNABLE_TO_RETRIEVE_TOKEN= "Unable to retrieve token";
        public const string MESSAGE_SUCCESS= "Success";
        public const string MESSAGE_FAILED= "Failed"; 
        
        public static string MESSAGE_RECORD_NOT_FOUND (string prefix )
        {
            return  prefix +   " does not exists";
        }

        public static string GET_ERROR(Exception exception )
        {
            return exception.Message;
        }
        public static string GET_SPECIAL_CHAR_NOT_ALLOWED(string fieldName)
        {
            return  $"Special character is not allowed for {fieldName}";
        }

        //Values
        //// public static  double RIDER_RANGE = 10000;
        ////public static double MERCHANT_RANGE = 10000;
        public static double TRAVEL_TIME = 15;//minutes

    }
}
