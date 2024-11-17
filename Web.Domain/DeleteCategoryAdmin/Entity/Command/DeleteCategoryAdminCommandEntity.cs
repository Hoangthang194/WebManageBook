using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.DeleteCategoryAdmin.Entity.Command
{
    [Table("Category")]

    public class DeleteCategoryAdminCommandEntity
    {
        [Key]
        public string? CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
