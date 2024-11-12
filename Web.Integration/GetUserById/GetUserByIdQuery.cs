using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.GetUserById.Query
{
    public class GetUserByIdQuery: IRequest<GetUserByIdQueryResult>
    {
        public string? UserId { get; set; }
    }
}
