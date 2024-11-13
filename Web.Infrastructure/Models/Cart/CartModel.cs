namespace Web.Infrastructure.Models.Cart
{
    public class CartModel
    {
        public int TotalNumberBook { get; set; }  
        public decimal TotalMoney { get; set; }
        //public IList<BookOfCartEntity> Products { get; set; } = new List<BookOfCartEntity>();
        public int IsLogin { get; set; } = 0;
        public string? CartId { get; set; }
    }
}
