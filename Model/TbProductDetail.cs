namespace TestAPI.Model
{
    public class TbProductDetail
    {
        public Guid id { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        // FK
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public Guid SizeId { get; set; }
        public Guid ImageId { get; set; }
        // Navigation
        public virtual TbColor colors { get; set; }
        public virtual TbImage images { get; set; }
        public virtual TbSize sizes { get; set; }
        public virtual TbProduct products { get; set; }
        public virtual ICollection<TbCartDetail> TbCartDetails { get; set; } = new List<TbCartDetail>();
        public virtual ICollection<TbOrderDetail> TbOrderDetails { get; set; } = new List<TbOrderDetail>();
    }
}
