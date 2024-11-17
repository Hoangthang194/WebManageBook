using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllStatusBook.Entity.Query;

namespace Web.Integration.GetAllStatusBook.Query
{
    public class GetAllStatusBookQueryResult
    {
        public List<GetAllStatusBookQueryEntity> Status { get; set; } = new List<GetAllStatusBookQueryEntity>();
    }
}
