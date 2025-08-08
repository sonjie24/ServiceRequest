using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AccountManagement.MicroService.Controllers
{
    public class AdminUpdateAccountRouteModel : AdminBaseRouteModel
    {
        public string ImagePath  { get; set; }
    }
}
