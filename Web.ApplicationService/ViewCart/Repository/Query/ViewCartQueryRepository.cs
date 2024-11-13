using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.ViewCart.Entity.Query;
using Web.Domain.ViewCart.Repository.Query;

namespace Web.ApplicationService.ViewCart.Repository.Query
{
    public class ViewCartQueryRepository: QueryRepository<ViewCartQueryEntity>, IViewCartQueryRepository
    {
        private readonly IDapperContext context;
        public ViewCartQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
    }
}
