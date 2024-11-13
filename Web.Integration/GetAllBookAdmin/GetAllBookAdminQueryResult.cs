using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllBookAdmin.Entity.Query;

namespace Web.Integration.GetAllBookAdmin.Query
{
    public class GetAllBookAdminQueryResult
    {
        public List<GetAllBookAdminQueryEntity> Books {  get; set; } = new List<GetAllBookAdminQueryEntity>();
    }
}
