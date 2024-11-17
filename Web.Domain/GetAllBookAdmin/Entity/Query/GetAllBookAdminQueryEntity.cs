using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.GetAllBookAdmin.Entity.Query
{
    [Table("Book")]
    public class GetAllBookAdminQueryEntity
    {
        [Key]
        public string? BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookSubDes { get; set; }
        public string? BookBrand { get; set; }
        public string? BookDes { get; set; }
        public int BookStatus { get; set; }
        public decimal PriceOld { get; set; }
        public decimal PriceNew { get; set; }
        public int PercentVourcher { get; set; }
        public int BookNumber { get; set; }
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? IsDeleted { get; set; }

    }
}
