namespace TestAPI.Model
{
    public class TbAccount
    {
        public Guid Id { get; set; }

        public string AccountCode { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }
        public Guid CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public Guid? UpdateBy { get; set; }

        public DateTime CreateDate { get; set; }
        public int? Role { get; set; }

        public virtual ICollection<TbAddress> TbAddresses { get; set; } = new List<TbAddress>();
    }
}
