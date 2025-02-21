namespace TestAPI.Model
{
    public class TbOrderDetail
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }


        public int Quantity { get; set; }
        //FK
        public Guid ProductDetailId { get; set; }
        public Guid OrderId { get; set; }


        //Navigation
        public virtual TbOrder Order { get; set; } = null!;

        public virtual TbProductDetail ProductDetail { get; set; } = null!;
    }
}
