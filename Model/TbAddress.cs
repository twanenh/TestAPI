namespace TestAPI.Model
{
    public class TbAddress
    {
        public Guid Id { get; set; }
        public string ProvinceName { get; set; } = null!;

        public string? DistrictName { get; set; }

        public string? WardName { get; set; }

        public bool? Status { get; set; }

        public bool? IsDelete { get; set; }
        public string? ReceiverName { get; set; }

        public string? ReceiverPhone { get; set; }
        //FK
        public Guid AccountId { get; set; }
        //Navigation
        public virtual TbAccount? TbAccount { get; set; } 
    }
}
