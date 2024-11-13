using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.GetAllBookAdmin.Entity.Query
{
    public class GetAllBookAdminQueryEntity
    {
        public string? BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookSubDes { get; set; }
        public string? BookBrand { get; set; }
        public string? BookDes { get; set; }
        public string? BookStatus { get; set; }
        public string? PriceOld { get; set; }
        public string? PriceNew { get; set; }
        public string? PercentVourcher { get; set; }
        public string? BookNumber { get; set; }
        public string? CategoryId { get; set; }
        public string? IsDeleted { get; set; }

    }
}
