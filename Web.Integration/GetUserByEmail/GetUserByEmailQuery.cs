using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.GetUserByEmail.Query
{
    public class GetUserByEmailQuery: IRequest<GetUserByEmailQueryResult>
    {
        public string? UserEmail {  get; set; }
    }
}
