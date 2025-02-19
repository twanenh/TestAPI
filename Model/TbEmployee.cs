namespace TestAPI.Model
{
    public class TbEmployee
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public DateOnly? BirthDay { get; set; }
        public string? Address { get; set; }

        public string? Phone { get; set; }
        public int? Sex { get; set; }
        public bool? Status { get; set; }

        public bool? InActive { get; set; }
        public bool? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public Guid? UpdateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreateBy { get; set; }
        //FK
        public Guid AccountId { get; set; }
        //Navigation
        public virtual TbAccount Account { get; set; }
    }
}
