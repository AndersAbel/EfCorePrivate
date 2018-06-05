using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options) { }

        public DbSet<MyEntity> MyEntities { get; set; }
    }
}
