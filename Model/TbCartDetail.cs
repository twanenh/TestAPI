namespace TestAPI.Model
{
    public class TbCartDetail
    {
        public Guid id { get; set; }
        public int quantity { get; set; }
        //FK
        public Guid ProductDetailId { get; set; }
        public Guid CartId { get; set; }
        //Navigation
        public virtual TbProductDetail productDetails { get; set; }
        public virtual TbCart carts { get; set; }
    }
}
