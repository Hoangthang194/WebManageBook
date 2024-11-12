using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetUserByEmail.Entity.Query;

namespace Web.Integration.GetUserByEmail.Query
{
    public class GetUserByEmailQueryResult
    {
        public GetUserByEmailQueryEntity User {  get; set; } = new GetUserByEmailQueryEntity();
    }
}
