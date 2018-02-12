using Microsoft.EntityFrameworkCore;
using WhoCalledMe.Entities;

namespace WhoCalledMe.DbContexts
{
    public class PhonebookDbContext : DbContext
    {
        public PhonebookDbContext(DbContextOptions<PhonebookDbContext> options)
            : base(options)
        { }


        public DbSet<Region> Regions { get; set; }
        public DbSet<DefCode> DefCodes { get; set; }
        public DbSet<Operator> Operators { get; set; }
    }
}
