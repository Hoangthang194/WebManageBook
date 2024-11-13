using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Query;
using Web.Domain.GetAllBookAdmin.Entity.Query;

namespace Web.Domain.GetAllBookAdmin.Repository.Query
{
    public interface IGetAllBookAdminQueryRepository : IQueryRepository<GetAllBookAdminQueryEntity>
    {
    }
}
