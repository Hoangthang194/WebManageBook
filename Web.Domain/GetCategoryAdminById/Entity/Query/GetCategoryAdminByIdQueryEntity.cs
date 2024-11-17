using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.GetCategoryAdminById.Entity.Query
{
    [Table("Category")]

    public class GetCategoryAdminByIdQueryEntity
    {
        [Key]
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }
    }
}
