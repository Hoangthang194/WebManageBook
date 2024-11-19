using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Query;
using Web.Domain.GetAllBook.Entity.Query;
using Web.Domain.GetAllBookAdmin.Entity.Query;

namespace Web.Domain.GetAllBook.Repository.Query
{
    public interface IGetAllBookQueryRepository : IQueryRepository<GetAllBookQueryEntity>
    {
        public Task<List<GetAllBookQueryEntity>> GetAllInforBookk();
    }
}
