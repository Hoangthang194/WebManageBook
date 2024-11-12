using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Query;
using Web.Domain.GetUserById.Entity.Query;

namespace Web.Domain.GetUserById.Repository.Query
{
    public interface IGetUserByIdQueryRepository : IQueryRepository<GetUserByIdQueryEntity>
    {
    }
}
