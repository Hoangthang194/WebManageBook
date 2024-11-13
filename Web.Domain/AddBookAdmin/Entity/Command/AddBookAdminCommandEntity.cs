using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.AddBookAdmin.Entity.Command
{
    public class AddBookAdminCommandEntity
    {
        public string? BookId { get; set; } = Guid.NewGuid().ToString();
        public string? BookName { get; set; }
        public string? BookSubDes { get; set; }
        public string? BookBrand { get; set; }
        public string? BookDes { get; set; }
        public string? BookStatus { get; set; }
        public decimal PriceOld { get; set; }
        public decimal PriceNew { get; set; }
        public string? PercentVourcher { get; set; }
        public string? BookNumber { get; set; }
        public string? CategoryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
