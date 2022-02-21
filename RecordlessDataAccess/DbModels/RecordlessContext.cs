using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RecordlessApi.DbModels;
using RecordlessDataAccess.DbModels;

#nullable disable

namespace RecordlessApi.DbModels
{
    public partial class RecordlessContext : DbContext
    {
        public RecordlessContext()
        {
        }

        public RecordlessContext(DbContextOptions<RecordlessContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Follower> Followers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Follower>(entity =>
            {
                entity.ToTable("Follower");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<RecordlessDataAccess.DbModels.Account> Account { get; set; }

        public DbSet<RecordlessDataAccess.DbModels.Client> Client { get; set; }

        public DbSet<RecordlessDataAccess.DbModels.Content> Content { get; set; }

        public DbSet<RecordlessDataAccess.DbModels.Following> Following { get; set; }
    }
}
