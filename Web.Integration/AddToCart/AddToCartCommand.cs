using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.AddToCart.Command
{
    public class AddToCartCommand : IRequest<AddToCartCommandResult>
    {
        public string? UserId { get; set; }
    }
}
