namespace TestAPI.Model
{
    public class TbCustomer
    {
        //Cân nhắc bỏ CreateBy
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Adress { get; set; }

        public string? Phone { get; set; }
        public int? Sex { get; set; }
        public bool? Status { get; set; }

        public bool? InActive { get; set; }

        public DateTime? UpdateDate { get; set; }

        public Guid? UpdateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreateBy { get; set; }
        //FK
        public Guid AccountId { get; set; }
        //Navigation
        public virtual TbAccount Account { get; set; }
        public virtual TbCart Cart { get; set; }

    }
}
