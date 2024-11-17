using System.ComponentModel.DataAnnotations;

namespace Web.Infrastructure.Areas.Admin.Models
{
    public class LoginAdminModel
    {
        [EmailAddress(ErrorMessage = "Email không đúng định dạng!")]
        public string? UserEmail { get; set; }
        [MinLength(8, ErrorMessage = "Mật khẩu tối đa 8 ký tự!")]
        public string? UserPassword { get; set; }
        public bool SavePass { get; set; }
    }
}
