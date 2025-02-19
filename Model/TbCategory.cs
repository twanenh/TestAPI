namespace TestAPI.Model
{
    public class TbCategory
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }
        public int? Status { get; set; }

        public bool? IsDelete { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public Guid? UpdateBy { get; set; }
        //Thiếu quan hệ đến bảng product do chưa rõ quan hệ
    }
}
