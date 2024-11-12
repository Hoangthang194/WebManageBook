using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Login.Entity.Query;
using Web.Domain.Login.Entity;
namespace Web.Integration.Login.Query
{
    public class LoginQueryResult
    {
        public LoginEntity LoginEntity { set; get; } = new(); 
	}
}
