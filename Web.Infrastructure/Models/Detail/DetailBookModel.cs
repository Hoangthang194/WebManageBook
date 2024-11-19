using Web.Domain.GetAllBook.Entity.Query;

namespace Web.Infrastructure.Models.Detail
{
    public class DetailBookModel
    {
        public string? BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookSubDes { get; set; }
        public string? BookBrand { get; set; }
        public string? BookDes { get; set; }
        public int BookStatus { get; set; }
        public string? BookStatusName { get; set; }
        public decimal PriceOld { get; set; }
        public decimal PriceNew { get; set; }
        public int PercentVourcher { get; set; }
        public int BookNumber { get; set; }
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? IsDeleted { get; set; }
        public List<GetAllBookQueryEntity> Books { get; set; } = new List<GetAllBookQueryEntity>();
    }
}
