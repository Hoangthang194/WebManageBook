using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.AddToCart
{
    public class BookOfCartEntity
    {
        public string? BookId { get; set; }
        public string? BookImg { get; set; }
        public string? BookName { get; set; }
        public decimal BookPrice { get; set; }
        public decimal TotalMoney { get; set; }
        public int TotalBook { get; set; }
        public decimal TotalCartMoney { get; set; }
        public int TotalCartBook { get; set; }
        public string? CartDetailId { get; set; }
    }
}
