using Microsoft.EntityFrameworkCore;
using PostOfficeIS.Models;

namespace TestDB.DB
{
    public class MyDBContext : DbContext
    {
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<PostOfficeEntity> PostOffices { get; set; }
        public DbSet<PositionEntity> Positions { get; set; }
        public DbSet<WorkerEntity> Workers { get; set; }
        public DbSet<WorkerProfileEntity> WorkerProfiles { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<ParcelEntity> Parcels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=PostOfficeDB;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionEntity>()
                .HasOne(t => t.Sender)
                .WithMany()
                .HasForeignKey(t => t.SenderId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ClientEntity>().ToTable("Clients");
            modelBuilder.Entity<CityEntity>().ToTable("Cities");
            modelBuilder.Entity<PostOfficeEntity>().ToTable("PostOffices");
            modelBuilder.Entity<PositionEntity>().ToTable("Positions");
            modelBuilder.Entity<WorkerEntity>().ToTable("Workers");
            modelBuilder.Entity<WorkerProfileEntity>().ToTable("WorkersProfiles");
            modelBuilder.Entity<TransactionEntity>().ToTable("Transactions");
            modelBuilder.Entity<ParcelEntity>().ToTable("Parcels");

            base.OnModelCreating(modelBuilder);
        }
        

    }
}
