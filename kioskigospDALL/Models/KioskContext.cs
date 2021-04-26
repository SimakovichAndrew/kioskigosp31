using Microsoft.EntityFrameworkCore;


namespace kioskigospDALL.Models
{
    public class KioskContext :DbContext
    {
        public DbSet<Kiosk> Kiosks { get; set; }


        public KioskContext(DbContextOptions<KioskContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
