using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Framework.Models
{ 

    public enum Result
    {
        None = 0,
        Success,
        Failed,
        Error,
        Forbidden
    }


    public enum ConsumerStatus
    {
        Active = 1,
        Pending = 2,
        Cancelled = 3,
        InActive=4,
        Blocked=5
    }

    public enum ConsumerFilterStatus
    {
        All = 0,
        Active = 1,
        Pending,
        Cancelled,
        InActive,
        Blocked
    }

    public enum RiderStatus
    {
        Active = 1,
        Pending = 2,
        Cancelled = 3,
        Blocked = 4,
    }

    public enum  RiderFilterStatus
    {
        All = 0,
        Active = 1,
        Pending,
        Cancelled,
        Blocked
    }

    public enum RiderDeliveryStat
    {
        UnAvailable=0,
        Available=1,
        Busy=2,
    }

    public enum RiderOnlineOffline
    {
        Offline = 0,
        Online = 1
    }


    public enum EStatus
    {
        Active = 1,
        Pending = 2,
        Cancelled = 3,
        Blocked = 4, 
    }

    public enum  FilterEStatus
    {
        All = 0,
        Active = 1,
        Pending,
        Cancelled,
        Blocked   
    }
}
