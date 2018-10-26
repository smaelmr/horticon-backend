using Core.Entities.Cycles;
using Core.Entities.Pesticides;
using Core.Entities.Plantations;
using Core.Entities.Users;
using Core.Entities.WashingPipes;
using Core.Entities.WaterChanges;
using Core.Entities.WaterControls;
using Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Planting> Planting { get; set; }
        public DbSet<Cycle> Cycle { get; set; }
        public DbSet<Pesticide> Pesticide { get; set; }
        public DbSet<WashingPipe> WashingPipe { get; set; }
        public DbSet<WaterChange> WaterChange { get; set; }
        public DbSet<WaterControl> WaterControl { get; set; }

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
            modelBuilder.Entity<Cycle>(new CycleMap().Configure);
            modelBuilder.Entity<Pesticide>(new PesticideMap().Configure);
            modelBuilder.Entity<WashingPipe>(new WashingPipeMap().Configure);
            modelBuilder.Entity<WaterChange>(new WaterChangeMap().Configure);
            modelBuilder.Entity<WaterControl>(new WaterControlMap().Configure);

        }
    }
}
