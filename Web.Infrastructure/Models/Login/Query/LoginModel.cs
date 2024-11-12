using System.ComponentModel.DataAnnotations;

namespace Web.Infrastructure.Models.Login
{
    public class LoginModel
    {
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Email không đúng định dạng!")]
        public string UserEmail { get; set; }   
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Mật khẩu nhập lại không khớp!")]
        public string RepeatPassword { get; set; }  

	}
}
