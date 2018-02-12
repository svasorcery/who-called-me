using System.Linq;

namespace WhoCalledMe.DbContexts
{
    public static partial class DbInitializer
    {
        public static void Initialize(PhonebookDbContext context)
        {
            context.Database.EnsureCreated();
            
            if (!context.Regions.Any())
            {
                context.Regions.AddRange(_regions);
                context.SaveChanges();
            }

            if (!context.Operators.Any())
            {
                context.Operators.AddRange(_operators);
                context.SaveChanges();
            }

            if (!context.DefCodes.Any())
            {
                context.DefCodes.AddRange(_defCodes);
                context.SaveChanges();
            }
        }
    }
}
