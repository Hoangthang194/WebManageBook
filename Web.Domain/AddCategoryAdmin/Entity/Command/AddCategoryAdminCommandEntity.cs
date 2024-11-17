using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Contact;

namespace Web.Domain.AddCategoryAdmin.Entity.Command
{
    [Table("Category")]
    public class AddCategoryAdminCommandEntity : BaseEntity
    {
        public string? CategoryId { get; set; } = Guid.NewGuid().ToString();
        public string? CategoryName { get; set; }

    }
}
