using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllBook.Entity.Query;
using Web.Domain.GetAllBookAdmin.Entity.Query;

namespace Web.Integration.GetAllBook.Query
{
    public class GetAllBookQueryResult
    {
        public List<GetAllBookQueryEntity> Books { get; set; } = new List<GetAllBookQueryEntity>();

    }
}
