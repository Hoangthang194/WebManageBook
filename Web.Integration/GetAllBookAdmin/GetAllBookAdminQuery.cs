using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllCategoryAdmin.Entity.Query;

namespace Web.Integration.GetAllBookAdmin.Query
{
    public class GetAllBookAdminQuery: IRequest<GetAllBookAdminQueryResult>
    {
        public List<GetAllCategoryAdminQueryEntity> Categories { get; set; } = new List<GetAllCategoryAdminQueryEntity>();
    }
}
