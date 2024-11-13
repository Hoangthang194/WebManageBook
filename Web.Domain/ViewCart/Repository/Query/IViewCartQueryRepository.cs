using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Query;
using Web.Domain.ViewCart.Entity.Query;

namespace Web.Domain.ViewCart.Repository.Query
{
    public interface IViewCartQueryRepository : IQueryRepository<ViewCartQueryEntity>
    {
    }
}
