using Microsoft.EntityFrameworkCore;
using Riode.Models.Entities;

namespace Riode.Models.DAL
{
    public class RiodeDbContext : DbContext
    {
        public RiodeDbContext() : base()
        {
            
        }
        public RiodeDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("Server = DESKTOP-18DA31; Database = RiodeWithGit; Trusted_Connection = True;");
            }
        }


        public DbSet<Contact> Contacts { get; set; }
    }
}
