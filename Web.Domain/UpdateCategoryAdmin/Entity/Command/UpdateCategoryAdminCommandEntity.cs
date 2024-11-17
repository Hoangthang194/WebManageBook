using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.UpdateCategoryAdmin.Entity.Command
{
    [Table("Category")]

    public class UpdateCategoryAdminCommandEntity
    {
        [Key]
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
