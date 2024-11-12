using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.Login.Query
{
    public class LoginQuery: IRequest<LoginQueryResult>
    {
		public string? UserEmail { get; set; }
		public string? UserPassword { get; set; }
	}
}
