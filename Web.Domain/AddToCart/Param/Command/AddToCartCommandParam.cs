using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Contact;

namespace Web.Domain.AddToCart.Param.Command
{
    public class AddToCartCommandParam 
    {
        public string? CartId { get; set; } = Guid.NewGuid().ToString();
        public string? UserId { get; set; }
        public decimal TotalNumber { get; set; }
        public decimal TotalMoney { get; set; }
    }
}
