using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.GetUserById.Entity.Query;
using Web.Domain.GetUserById.Repository.Query;

namespace Web.ApplicationService.GetUserById.Repository.Query
{
    public class GetUserByIdQueryRepository: QueryRepository<GetUserByIdQueryEntity>, IGetUserByIdQueryRepository
    {
        private readonly IDapperContext context;
        public GetUserByIdQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
    }
}
