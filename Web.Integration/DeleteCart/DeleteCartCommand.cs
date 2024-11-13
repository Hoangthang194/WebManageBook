using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.DeleteCart.Command
{
    public class DeleteCartCommand : IRequest<DeleteCartCommandResult>
    {
    }
}
