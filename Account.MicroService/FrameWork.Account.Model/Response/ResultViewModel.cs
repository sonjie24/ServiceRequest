using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Framework.Models
{
    public class ResultViewModel
    {
        public ResultViewModel()
        {
            ResultEnum =  Result.None.ToString();
        }
        public string ResultEnum { get; set; }
        public string ResultMessage { get; set; }
        public object ResultObject { get; set; }
        public string[] ResultArray { get; set; }

        public string ResultVariable{ get; set; }

        public ResultViewModel(string resultEnum, string resultMessage, object resultObject, string[] resultArray, string resultVariable)
        {
            ResultEnum = resultEnum ?? Result.Failed.ToString();
            ResultMessage = resultMessage ?? "";
            ResultObject = resultObject ?? null;
            ResultArray = resultArray ??  null;
            ResultVariable = resultVariable ?? null;
        }
    }

    public class ResultSuccess : ResultViewModel
    {
        public ResultSuccess()
        {
            ResultEnum = Result.Success.ToString();
            ResultMessage = "Success";
        }
        public ResultSuccess(object data)
        {
            ResultEnum = Result.Success.ToString();
            ResultMessage = "Success";
            ResultObject = data;
        }

    }
    public class ResultFailed : ResultViewModel
    {
        public ResultFailed()
        {
            ResultEnum = Result.Failed.ToString();
            ResultMessage = "Failed";
        }
        public ResultFailed(Exception exception)
        {
            ResultEnum = Result.Failed.ToString();
            ResultMessage = exception.Message;
        }
        public ResultFailed(string message)
        {
            ResultEnum = Result.Failed.ToString();
            ResultMessage = message;
        }
    }

}
