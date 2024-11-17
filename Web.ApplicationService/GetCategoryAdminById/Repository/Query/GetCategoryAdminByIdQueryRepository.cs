using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.GetCategoryAdminById.Entity.Query;
using Web.Domain.GetCategoryAdminById.Repository.Query;

namespace Web.ApplicationService.GetCategoryAdminById.Repository.Query
{
    public class GetCategoryAdminByIdQueryRepository: QueryRepository<GetCategoryAdminByIdQueryEntity>, IGetCategoryAdminByIdQueryRepository
    {
        private readonly IDapperContext context;
        public GetCategoryAdminByIdQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
    }
}
