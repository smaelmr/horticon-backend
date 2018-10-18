using Core.Entities.Plantations;
using Core.Entities.Users;
using Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Planting> Planting {get;set;}

        public MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) 
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("server=mysql.horticon.com.br;user id=horticon;password=homhorticon2018;persistsecurityinfo=True; database=horticon");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Planting>(new PlantingMap().Configure);
        }
    }
}
