using System.ComponentModel.DataAnnotations;

namespace Web.Infrastructure.Models.Login
{
    public class LoginModel
    {
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Email không đúng định dạng!")]
        public string UserEmail { get; set; }
        [MinLength(8, ErrorMessage = "Mật khẩu tối thiểu 8 ký tự")]   
        
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Mật khẩu nhập lại không khớp!")]
        public string RepeatPassword { get; set; }
        public string UserEmailLogin { get; set; }

        public string PasswordLogin { get; set; }

    }
}
