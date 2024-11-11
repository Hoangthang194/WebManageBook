using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.Login.Entity.Query;
using Web.Domain.Login.Repository.Query;

namespace Web.ApplicationService.Login.Repository.Query
{
    public class LoginQueryRepository: QueryRepository<LoginQueryEntity>, ILoginQueryRepository
    {
        private readonly IDapperContext context;
        public LoginQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
    }
}
