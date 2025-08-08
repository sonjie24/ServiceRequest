using System.ComponentModel.DataAnnotations;

namespace AccountManagement.MicroService.Controllers
{
    public class ConsumerUpdateAccountRouteModel
    {
        //[StringLength(255, ErrorMessage = "Email is too long.")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }
        public string ImagePath  { get; set; }
    }
}
