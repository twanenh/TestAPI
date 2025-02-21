namespace TestAPI.Model
{
    public class TbImage
    {
        public Guid Id { get; set; }
        public string url { get; set; }
        public string? type { get; set; }
        public bool? status { get; set; }
        public virtual ICollection<TbProductDetail> TbProductDetails { get; set; } = new List<TbProductDetail>();

    }
}
