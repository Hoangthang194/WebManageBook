using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.AddToCart;

namespace Web.Integration.AddToCart
{
    public class AddToCartDetailCommandResult
    {
        public bool Status { get; set; }
        public IList<BookOfCartEntity>? Books { get; set; }
        public decimal TotalMoney { get; set; }
        public int TotalBook { get; set; }
    }
}
