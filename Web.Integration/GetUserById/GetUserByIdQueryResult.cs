using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetUserById.Entity.Query;

namespace Web.Integration.GetUserById.Query
{
    public class GetUserByIdQueryResult
    {
        public GetUserByIdQueryEntity User {  get; set; } = new GetUserByIdQueryEntity();
    }
}
