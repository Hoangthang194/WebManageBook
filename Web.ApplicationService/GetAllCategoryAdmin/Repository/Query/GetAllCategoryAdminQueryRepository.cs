using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.GetAllCategoryAdmin.Entity.Query;
using Web.Domain.GetAllCategoryAdmin.Repository.Query;

namespace Web.ApplicationService.GetAllCategoryAdmin.Repository.Query
{
    public class GetAllCategoryAdminQueryRepository: QueryRepository<GetAllCategoryAdminQueryEntity>, IGetAllCategoryAdminQueryRepository
    {
        private readonly IDapperContext context;
        public GetAllCategoryAdminQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
    }
}
