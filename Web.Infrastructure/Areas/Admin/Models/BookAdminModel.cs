using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Domain.GetAllBookAdmin.Entity.Query;
using Web.Domain.GetAllCategoryAdmin.Entity.Query;
using Web.Domain.GetAllStatusBook.Entity.Query;

namespace Web.Infrastructure.Areas.Admin.Models
{
    public class BookAdminModel
    {
        public string? BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookSubDes { get; set; }
        public string? BookBrand { get; set; }
        public string? BookDes { get; set; }
        public string? BookStatus { get; set; }
        public decimal PriceOld { get; set; }
        public decimal PriceNew { get; set; }
        public int PercentVourcher { get; set; }
        public int BookNumber { get; set; }
        public string? CategoryId { get; set; }
        public List<GetAllCategoryAdminQueryEntity> Categories { get; set; } = new List<GetAllCategoryAdminQueryEntity>();
        public List<GetAllStatusBookQueryEntity> Status { get; set; } = new List<GetAllStatusBookQueryEntity>();
        public List<GetAllBookAdminQueryEntity> Books { get; set; } = new List<GetAllBookAdminQueryEntity>();
    }
}
