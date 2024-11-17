using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.GetAllCategoryAdmin.Entity.Query
{
    [Table("Category")]
    public class GetAllCategoryAdminQueryEntity
    {
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }

    }
}
