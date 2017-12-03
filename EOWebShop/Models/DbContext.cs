using System.Data.Entity;

namespace EOWebShop.Models
{
    public class ApplicationDbContext : DbContext
    {
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public DbSet<Proizvod> Proizvodi { get; set; }
    }
}