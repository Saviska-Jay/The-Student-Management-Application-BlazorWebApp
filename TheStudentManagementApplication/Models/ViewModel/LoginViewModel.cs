using System.ComponentModel.DataAnnotations;

namespace TheStudentManagementApplication.Models.ViewModel
{
    public class LoginViewModel
    {

        [Required(AllowEmptyStrings =false, ErrorMessage ="Please Enter Your Username !")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Your Password !")]
        public string? Password { get; set; }
         
    }
}
