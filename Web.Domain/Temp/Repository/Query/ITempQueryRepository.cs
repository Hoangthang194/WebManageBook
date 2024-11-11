using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Query;
using Web.Domain.Temp.Entity.Query;

namespace Web.Domain.Temp.Repository.Query
{
    public interface ITempQueryRepository : IQueryRepository<TempQueryEntity>
    {
    }
}
