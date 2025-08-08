using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService  
{    
    public static class ApiRoutes
    { 
        public const string  Base = "api/v1";
        public const string  Base2 = "api/v2";

        public static class MerchantStoreCategories
        {
            public const string Addcategoties = Base + "/merchant/store/category/add-category";
            public const string Update = Base + "/merchant/store/category/update-categories/{categoryId}";
            public const string Get = Base + "/merchant/store/category/{categoryId}";
            public const string GetAll = Base + "/merchant/store/category";
            public const string Delete = Base + "/merchant/store/category/{categoryId}";
        }

        public static class MechantStoreRoute
        {
            public const string AddRelatedStore = Base + "/merchant/add-related-store/register"; 
            public const string GetRelatedStore = Base + "/merchant/get-related-store/{BranchGroup}/{merchantId}"; 
            public const string RegisterStore = Base + "/merchant/store/register"; 
            public const string Update = Base + "/merchant/store/{merchantId}";
            public const string UpdateStatus = Base + "/merchant/store/updatestatus/{merchantId}/{status}";
            public const string UpdateMinimumPurchase = Base + "/merchant/store/set-minimum-order/{merchantId}/{amount}";
            public const string GetMinimumPurchase = Base + "/merchant/store/get-minimum-order/{merchantId}";
            public const string SetDocIsComplied = Base + "/merchant/store/set-doc-is-complied/{merchantId}/{isComplied}";

            public const string VerifyEmail = Base + "/s-verify-account/{storeUserId}";
            public const string Get = Base + "/merchant/store/{merchantId}";
            public const string GetAll = Base + "/merchant/{status}/{skip}/{take}";
            public const string GetNearestRider  = Base + "/nearest-rider/{skip}/{take}";

            public const string UpdateLongLat = Base + "/merchant/store/update-location/{merchantId}";
            public const string Delete = Base + "/merchant/store/{userId}";
            //public const string storeIsOn = Base + "/merchant/store-is-online/{merchantId}/{isOnline}";
            //public const string storeIsPaused= Base + "/merchant/store-is-pause/{merchantId}/{isPause}";

            public const string storeIsCloseCurrent = Base + "/merchant/store-is-close-current/{merchantId}/{isClose}";
            public const string storeIsCloseAllDays = Base + "/merchant/store-is-close-all-days/{merchantId}/{isClose}";


            public const string storeIsCloseCurrentV2= Base2 + "/merchant/store-is-close-current";
            public const string storeIsCloseAllDaysV2= Base2 + "/merchant/store-is-close-all-days";

          
        }


        public static class MechantAccountRoute
        {
            public const string RegisterUser = Base + "/merchant/user/register";
            public const string Update = Base + "/merchant/user/update-account/{userId}";

            public const string Login = Base + "/merchant/user/login";
            public const string VerifyEmail = Base + "/m-verify-account/{userGuid}";

            public const string GetAll = Base + "/merchant/user/{merchantId}/{status}/{skip}/{take}/{role}";
            public const string Get = Base + "/merchant/user/{userId}";
            public const string UpdateStatus = Base + "/merchant/user/updatestatus/{userId}/{status}";
            public const string Delete = Base + "/merchant/user/{userId}";
            public const string RefreshToken  = Base + "/merchant/user/refresh-token";

            public const string ChangePassword = Base + "/merchant/user/change-password";
            public const string ResetPassword = Base + "/merchant/user/reset-password";
            public const string EmailReset  = Base + "/merchant/user/email-reset-account";

            public const string GetContatcs = Base + "/merchant-contacts";
        }

        public static class AdminAccountRoute
        {
            public const string Register = Base + "/admin/register";
            public const string AddUserType = Base + "/admin/add-user-type";
            public const string UpdateUserType = Base + "/admin/update-user-type";
            public const string Update = Base + "/admin/update-account/{userId}";
            public const string Login = Base + "/admin/login";
            public const string Get = Base + "/admin/{userId}";
            public const string GetAll = Base + "/admin/{status}/{skip}/{take}/{role}";
            public const string GetContatcs = Base + "/admin-contacts/{type}";
            public const string UpdateStatus = Base + "/admin/updatestatus/{userId}/{status}";
            public const string Delete = Base + "/admin/{userId}";
            public const string RefreshToken = Base + "/admin/refresh-token";


            public const string ChangePassword = Base + "/admin/change-password";
            public const string ResetPassword = Base + "/admin/reset-password";
            public const string EmailReset = Base + "/admin/email-reset-account";
        }

        public static class RiderAccountRoute
         {
            public const string Register = Base + "/rider/register";
            public const string Register2 = Base2 + "/rider/register";
            public const string Update = Base + "/rider/update-account/{userId}";
            public const string UpdateLimit  = Base + "/rider/update-account-booking-limit/{userId}/{limitAmount}";
            public const string Login = Base + "/rider/login";
            public const string LoginV2 =  Base2 + "/rider/login";
          
            public const string UpdateStatus = Base + "/rider/updatestatus/{userId}/{status}";
            public const string UpdateLongLat = Base + "/rider/update-location";

            public const string UpdateOnlineOfflineStatusV1 = Base + "/rider/update-delivery-status/{userId}/{status}/{latitude}/{longitude}";
            public const string UpdateOnlineOfflineStatusV2 = Base2 + "/rider/update-Online-offline-status/{userId}/{status}/{latitude}/{longitude}"; 
            public const string UpdateDeliveryStatus = Base + "/rider/update-delivery-status/{userId}/{status}"; 

            public const string GetAll = Base + "/rider/{status}/{skip}/{take}";
            public const string Get = Base + "/rider/{userid}";
            public const string GetIsDocsComplied = Base + "/rider-docs-complied/{riderId}";
            public const string Delete = Base + "/rider/{userId}";
            public const string RefreshToken = Base + "/rider/refresh-token";
            public const string ChangePassword = Base + "/rider/change-password";
            public const string ResetPassword = Base + "/rider/reset-password";
            public const string VerifyEmailOrMobile= Base + "/rider/verify-email-mobile";
            public const string RegisterMobile = Base + "/rider/register-mobile-no";

            public const string GetRiderActivityStatus = Base + "/rider/activities/{riderId}";
            public const string AddRiderActivityStatus = Base + "/rider/activities/{riderId}";


            public const string GetContatcs = Base + "/rider-contacts";

            public const string GetContatcsRatings = Base + "/rider-ratings/{rating}";
        }

        public static class RatingsRoute
        {
            public static class  ConsumerToRider 
            {
                public const string AddRating = Base + "/consumer-to-rider/add-rating";
                public const string GetRating = Base + "/consumer-to-rider/get-rating/{riderId}/{skip}/{take}";
                public const string GetTotalRating = Base + "/consumer-to-rider/get-rating-total/{riderId}";
            }
            public static class ConsumerToMerchant 
            {
                public const string AddRating = Base + "/consumer-to-merchant/add-rating";
                public const string GetRating = Base + "/consumer-to-merchant/get-rating/{merchantId}/{skip}/{take}";
                public const string GetTotalRating = Base + "/consumer-to-merchant/get-rating-total/{merchantId}";
            }
            public static class  RiderToMerchant
            {
                public const string AddRating = Base + "/rider-to-merchant/add-rating";
                public const string GetRating = Base + "/rider-to-merchant/get-rating/{merchantId}/{skip}/{take}";
                public const string GetTotalRating = Base + "/rider-to-merchant/get-rating-total/{merchantId}";
            }
        }

        public static class RiderRequirementRoute  
        {
            public const string Add  = Base + "/rider-document-requirement/{riderId}";
            public const string Update   = Base + "/rider-document-requirement/{riderId}/{documentId}";
            public const string GetAll  = Base + "/rider-document-requirement/{riderId}";
            public const string GetBydocumentDocumentId = Base + "/rider-document-requirement/{riderId}/{documentId}";
            public const string GetBydocumentDocumentName = Base + "/rider-document-requirement-name/{riderId}/{documentName}";
            public const string Remove = Base + "/rider-document-requirement/{riderId}/{documentId}";
            public const string RemoveAll = Base + "/rider-document-requirement-all/{riderId}";
        }

        public static class MerchantRequirementRoute
        {
            public const string Add = Base + "/merchant-document-requirement/{merchantId}";
            public const string Update = Base + "/merchant-document-requirement/{merchantId}/{documentId}";
            public const string GetAll = Base + "/merchant-document-requirement/{merchantId}";
            public const string GetBydocumentDocumentId = Base + "/merchant-document-requirement/{merchantId}/{documentId}";
            public const string GetBydocumentDocumentName = Base + "/merchant-document-requirement-name/{merchantId}/{documentName}";
            public const string Remove = Base + "/merchant-document-requirement/{merchantId}/{documentId}";
            public const string RemoveAll = Base + "/merchant-document-requirement-all/{merchantId}";
        }

        public static class RiderTopUpRoute 
        {
            public const string Topup = Base + "/rider-topup/{riderId}";
            public const string updateTopUpStatus = Base + "/rider-topup/update-topup-status/{topupId}/{status}";
            public const string TopupBalanceTotal   = Base + "/rider-topup-balance/{riderId}/{WalletId}";
            public const string TopupBalanceTransactions   = Base + "/rider-topup-transactions/{riderId}/{WalletId}/{skip}/{take}";
            public const string SetDefaultWallet = Base + "/rider-topup-set-default-wallet/{riderId}/{WalletId}";
            public const string GetDefaultWallet = Base + "/rider-topup-get-default-wallet/{riderId}";
        }

        public static class WalletRoute
        {
            public const string AddWallet = Base + "/Wallet";
            public const string AllWallet = Base + "/Wallet";
            public const string UpdateWallet = Base + "/Wallet/{WalletId}";
            public const string UpdateStatus = Base + "/Wallet/{WalletId}/{status}";
            //public const string RemoveWallet = Base + "/rider-topup-Wallet/{WalletId}";
        }

        public static class ConsumerAccountRoute
        {
            public const string Register = Base + "/consumer/register";
            public const string RegisterByDevice = Base + "/consumer/register-device/{deviceId}";
            public const string update = Base + "/consumer/update-account/{userId}";
            public const string Login = Base + "/consumer/login";
            public const string LoginByDeviceId = Base + "/consumer/login-by-device/{deviceId}";
            public const string GetAll = Base + "/consumer/{status}/{skip}/{take}";
            public const string GetNearestMerchantAllByName  = Base + "/nearest-merchant-all/{longitude}/{latitude}/{merchantName}";
            public const string GetNearestMerchantAll  = Base + "/nearest-merchant-all/{longitude}/{latitude}/{skip}/{take}";
            public const string GetNearestMerchantCategory  = Base + "/nearest-merchant-category/{category}/{longitude}/{latitude}/{skip}/{take}";
            public const string GetNearestMerchantFavorites   = Base + "/nearest-merchant-favorites/{longitude}/{latitude}/{skip}/{take}";
            public const string GetMerchantSchedule    = Base + "/get-merchant-schedule";
            public const string Get= Base + "/consumer/{userId}";
            public const string Update = Base + "/consumer/{userId}";
            public const string UpdateLongLat = Base + "/consumer/update-location";
            public const string Delete = Base + "/consumer/{userId}";
            public const string GetBySocialId = Base + "/consumer/get-by-social-id/{socialId}";
            public const string RegisterMobile = Base + "/consumer/register-mobile/{mobileNo}";
            public const string UpdateStatus = Base + "/consumer/updatestatus/{userId}/{status}";
            public const string AddFavoriteMerchant  = Base + "/consumer/add-favorite-merchant/{userId}/{merchantId}";
            public const string RemoveFavoriteMerchant  = Base + "/consumer/remove-favorite-merchant/{userId}/{merchantId}";
            public const string RefreshToken = Base + "/consumer/refresh-token";
            //address
            public const string addressAdd = Base + "/consumer-address/{consumerId}"; 
            public const string addressUpdate = Base + "/consumer-address/{consumerId}/{address_id}"; 
            public const string addressAll = Base + "/consumer-addresses/{consumerId}";
            public const string removeaddress = Base + "/consumer-address/{consumerId}/{address_id}"; 
            public const string SetDefault = Base + "/consumer-address/{consumerId}/{address_id}"; 
            public const string GetDefault = Base + "/consumer-address-default/{consumerId}";

            //Contacts
            public const string GetContatcs = Base + "/consumer-contacts";
            //public const string ChangePassword = Base + "/consumer/change-password";
            //public const string ResetPassword = Base + "/consumer/reset-password";
        }




        public static class DeviceDetails
        {
            public const string Get = Base + "/device/{userId}";

            public const string Save = Base + "/device";

            public const string Update = Base + "/device";

            public const string StatusUpdate = Base + "/device/{status}/{id}";

        }
        public static class PersonWorkExperience
        {
            public const string Get = Base + "/workexperience/{personid}";

            public const string Save = Base + "/workexperience";

            public const string Update = Base + "/workexperience/{personId}";

            public const string Delete = Base + "/workexperience/{id}";
        }
        public static class PersonProfile
        {
            public const string Get = Base + "/personprofile/{id}";

            public const string GetAll = Base + "/personprofile/{status}/{take}/{skip}";

            public const string Save = Base + "/personprofile";

            public const string Update = Base + "/personprofile";

            public const string Delete = Base + "/personprofile/{id}";

            public const string UpdateUser = Base + "/personprofile/{id}";

        }
        public static class Favorites
        {
            public const string Get = Base + "/favorites/{clientId}";

            public const string Save = Base + "/favorites";

            public const string Update = Base + "/favorites";

            public const string StatusUpdate = Base + "/favorites/{status}/{id}";

        }
  
        
    }
}
