using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.Core.Query
{
    public interface IQueryRepository<T>
    {
        Task<T> GetById(string id);
        Task<IEnumerable<T>> GetAll();
        Task<int> CountAll();
    }
}
