using Web.Domain.GetAllCategoryAdmin.Entity.Query;

namespace Web.Infrastructure.Areas.Admin.Models
{
    public class CategoryAdminModel
    {
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public List<GetAllCategoryAdminQueryEntity> Categories { get; set; } = new List<GetAllCategoryAdminQueryEntity>();
    }
}
