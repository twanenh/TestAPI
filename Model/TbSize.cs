﻿namespace TestAPI.Model
{
    public class TbSize
    {
        public Guid Id { get; set; }
        public string SizeName { get; set; }
        public int quantity { get; set; }
        public double? footLength { get; set; }
        public virtual ICollection<TbProductDetail> TbProductDetails { get; set; } = new List<TbProductDetail>();
    }
}
