using AccountManagement.Framework.Models;
using Microsoft.AspNetCore.Http;
using NetTopologySuite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccountManagement.MicroService
{
    public  static class GobalExtensions
    {
        internal static string GetUserId(this HttpContext httpContext)
        {
            if (httpContext == null)
            {
                return string.Empty;
            }
            var item = httpContext.User.Claims;
            return item.Single(x => x.Type == "id").Value;
        }

        internal static bool hasSpecialChar(this string inputString)
        {
            var str = inputString.Trim();
            if (string.IsNullOrWhiteSpace(inputString)) return false;
            var withoutSpecial = new string(str.Where(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)).ToArray());
            if (str != withoutSpecial) return true;
            return false;
        }

        internal static RiderStatus convertToEStatus (this RiderFilterStatus stat)
        {
            switch (stat)
            {
                case RiderFilterStatus.Pending:
                    return  RiderStatus.Pending;
                case RiderFilterStatus.Cancelled:
                    return  RiderStatus.Cancelled; 
                case RiderFilterStatus.Blocked:
                    return RiderStatus.Blocked;
                default:
                    return  RiderStatus.Active;
            }
        }

        internal static ConsumerStatus convertToEStatus(this  ConsumerFilterStatus stat)
        {
            switch (stat)
            {
                case ConsumerFilterStatus.Pending:
                    return ConsumerStatus.Pending;
                case ConsumerFilterStatus.Cancelled:
                    return ConsumerStatus.Cancelled;
                case ConsumerFilterStatus.InActive:
                    return ConsumerStatus.InActive;
                case ConsumerFilterStatus.Blocked:
                    return ConsumerStatus.Blocked;
                default:
                    return ConsumerStatus.Active;
            }
        }


        internal static EStatus convertToEStatus(this  FilterEStatus stat)
        {
            switch (stat)
            {
                case FilterEStatus.Pending:
                    return EStatus.Pending;
                case FilterEStatus.Cancelled:
                    return EStatus.Cancelled;
                case FilterEStatus.Blocked:
                    return EStatus.Blocked;
                default:
                    return EStatus.Active;
            }
        }

    }
}
