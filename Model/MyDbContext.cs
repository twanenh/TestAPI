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
        public DbSet<Class> Classes { get; set; }
    }
}
