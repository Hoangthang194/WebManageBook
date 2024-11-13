using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.AddToCart
{
    internal class AddToCartDetailCommand : IRequest<AddToCartDetailCommandResult>
    {
        public string? BookId { get; set; }
        public string? UserId { get; set; }
        public int BookNumber { get; set; }
        public decimal BookPrice { get; set; }
        public string? CartId { get; set; }
    }
}
