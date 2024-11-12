using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Query;
using Web.Domain.Login.Entity;
using Web.Domain.Login.Entity.Query;
using Web.Domain.Login.Param.Query;

namespace Web.Domain.Login.Repository.Query
{
    public interface ILoginQueryRepository : IQueryRepository<LoginQueryEntity>
    {
		public Task<LoginEntity> GetLoginInformation(LoginQueryParam param);
	}
}
