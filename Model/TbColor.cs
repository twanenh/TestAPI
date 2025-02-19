namespace TestAPI.Model
{
    public class TbColor
    {
        public Guid id { get; set; }   
        public string name { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Status { get; set; }
        public DateTime? UpdateDate { get; set; }

        public Guid? UpdateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreateBy { get; set; }

    }
}
