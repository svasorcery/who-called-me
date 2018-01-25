using WhoCalledMe.Models;
using Microsoft.EntityFrameworkCore;

namespace WhoCalledMe.DbContexts
{
    public class PhonebookDbContext : DbContext
    {
        public PhonebookDbContext(DbContextOptions<PhonebookDbContext> options) 
            : base(options)
        { }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
