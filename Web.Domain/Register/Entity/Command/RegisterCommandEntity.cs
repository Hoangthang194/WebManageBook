using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.Register.Entity.Command
{
    [Table("Users")]
    public class RegisterCommandEntity
    {
        public string? UserId { get; set; } = Guid.NewGuid().ToString();
        [Column("UserFullName")]
        public string? UserName { get; set;}
        [Column("UserPassword")]
        public string? Password { get; set; }
        public string? UserEmail {  get; set; }
        public string? RoleId { get; set; } = "1";
    }
}
