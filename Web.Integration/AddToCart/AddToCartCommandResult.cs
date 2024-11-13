using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.AddToCart;

namespace Web.Integration.AddToCart.Command
{
    public class AddToCartCommandResult
    {
        public bool Status { get; set; }
        public int NumberBook { get; set; }
        public decimal TotalCart { get; set; }
        public IList<BookOfCartEntity> ProductOfCart { get; set; } = new List<BookOfCartEntity>();
        public int IsLogin { get; set; } = 0;
    }
}
