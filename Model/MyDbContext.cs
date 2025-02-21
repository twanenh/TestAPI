using Microsoft.EntityFrameworkCore;

namespace TestAPI.Model
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }
        public DbSet<TbColor> TbColors { get; set; }
        public DbSet<TbProduct> TbProducts { get; set; }
        public DbSet<TbProductDetail> TbProductDetails { get; set; }
        public DbSet<TbAddress> TbAddresses { get; set; }
        public DbSet<TbAccount> TbAccount { get; set; }
        public DbSet<TbCart> TbCarts { get; set; }
        public DbSet<TbCartDetail> TbCartDetails { get; set; }
        public DbSet<TbCategory> TbCategories { get; set; }
        public DbSet<TbCustomer> TbCustomers { get; set; }
        public DbSet<TbOrder> TbOrders { get; set; }
        public DbSet<TbOrderDetail> TbOrderDetails { get; set; }
        public DbSet<TbImage> TbImages { get; set; }
        public DbSet<TbEmployee> TbEmployees { get; set; }
        public DbSet<TbMaterial> TbMaterials { get; set; }
        public DbSet<TbShoeHeight> TbShoeHeights { get; set; }
        public DbSet<TbSize> TbSizes { get; set; }
        public DbSet<TbTechnology> TbTechnologies { get; set; }
        public DbSet<TbVoucher> TbVouchers { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<TbOrder>()
        //        .HasOne(o => o.Customer)
        //        .WithMany()
        //        .HasForeignKey(o => o.CustomerId)
        //        .OnDelete(DeleteBehavior.Cascade); // Xóa đơn hàng khi xóa khách hàng

        //    modelBuilder.Entity<TbOrder>()
        //        .HasOne(o => o.Employee)
        //        .WithMany()
        //        .HasForeignKey(o => o.EmployeeId)
        //        .OnDelete(DeleteBehavior.NoAction); // Không tự động xóa đơn hàng khi xóa nhân viên

        //    modelBuilder.Entity<TbOrder>()
        //        .HasOne(o => o.Voucher)
        //        .WithMany()
        //        .HasForeignKey(o => o.VoucherId)
        //        .OnDelete(DeleteBehavior.SetNull); // Nếu voucher bị xóa, đơn hàng vẫn tồn tại với VoucherId = NULL
        //}

    }
}
