using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Query;
using Web.Domain.GetUserByEmail.Entity.Query;
using Web.Domain.GetUserByEmail.Param.Query;

namespace Web.Domain.GetUserByEmail.Repository.Query
{
    public interface IGetUserByEmailQueryRepository : IQueryRepository<GetUserByEmailQueryEntity>
    {
        public Task<GetUserByEmailQueryEntity> GetUserByEmail(GetUserByEmailQueryParam param);
    }
}
