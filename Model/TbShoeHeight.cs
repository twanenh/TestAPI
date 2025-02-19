namespace TestAPI.Model
{
    public class TbShoeHeight
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<TbProduct> TbProducts { get; set; } = new List<TbProduct>();
    }
}
