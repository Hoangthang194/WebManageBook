using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetCategoryAdminById.Entity.Query;

namespace Web.Integration.GetCategoryAdminById.Query
{
    public class GetCategoryAdminByIdQueryResult
    {
        public GetCategoryAdminByIdQueryEntity Category {  get; set; } = new GetCategoryAdminByIdQueryEntity();
    }
}
