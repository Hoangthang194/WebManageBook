using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.Temp.Entity.Query;
using Web.Domain.Temp.Repository.Query;

namespace Web.ApplicationService.Temp.Repository.Query
{
    public class TempQueryRepository: QueryRepository<TempQueryEntity>, ITempQueryRepository
    {
        private readonly IDapperContext context;
        public TempQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
    }
}
