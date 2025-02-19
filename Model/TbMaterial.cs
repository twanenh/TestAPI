namespace TestAPI.Model
{
    public class TbMaterial
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public virtual ICollection<TbProduct> TbProducts { get; set; } = new List<TbProduct>();

    }
}
