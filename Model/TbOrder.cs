namespace TestAPI.Model
{
    public class TbOrder
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public decimal Total { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? Discount { get; set; }
        public bool? Status { get; set; }
        //Thiếu Address do chưa chốt được bảng
        public int PaymentMethod { get; set; }
        public string? receiverName { get; set; }
        public string? receiverPhone { get; set; }
        public decimal SubTotal { get; set; }
        public string? Code { get; set; }


        //FK
        public Guid CustomerId { get; set; }
        public Guid VoucherId { get; set; }
        public Guid EmployeeId { get; set; }
        //Navigation
        public virtual TbCustomer Customer { get; set; }
        public virtual TbVoucher Voucher { get; set; }
        public virtual TbEmployee Employee { get; set; }
    }
}
