namespace TestAPI.Model
{
    public class TbVoucher
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public string Code { get; set; } = null!;
        

        public VoucherType Type { get; set; }
        public decimal Discount { get; set; }
        public decimal MaxDiscount { get; set; }
        public int quantity { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Status { get; set; } 
        public  Guid? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        //Thiếu condition do chưa xác định được kiểu dữ liệu

        //Navigation
        public virtual ICollection<TbOrder> Orders { get; set; } = new List<TbOrder>();
        public enum VoucherType : short
        {
            Voucher = 0
        }
        //public enum Status : short
        //{
        //    Closed = 1,
        //    Valid = 2
        //}
    }
}
