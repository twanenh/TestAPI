namespace TestAPI.Model
{
    public class TbCart
    {
        public Guid id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        //FK
        public Guid CustomerId { get; set; }
        //Navigation
        public virtual TbCustomer Customer { get; set; }
    }
}
