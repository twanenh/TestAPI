namespace TestAPI.Model
{
    public class TbProduct
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int? status { get; set; }
        public string? description { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDelete { get; set; }
        public string? Code { get; set; }
        public string Brand { get; set; }
        // FK
        public Guid MaterialId { get; set; }
        public Guid ShoeHeightId { get; set; }
        public Guid TechnologyId { get; set; }
        public Guid CategoryId { get; set; }

        // Navigation 
        public virtual TbMaterial material { get; set; }
        public virtual TbShoeHeight shoeHeight { get; set; }
        public virtual TbTechnology technology { get; set; }
        public virtual TbCategory category { get; set; }

        ////Thiếu FK đến bảng Category do không rõ quan hệ


    }
}
