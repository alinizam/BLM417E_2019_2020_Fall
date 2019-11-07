using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lesson7App1.Models
{
    public partial class PersonelDBContext : DbContext
    {
        public PersonelDBContext()
        {
        }

        public PersonelDBContext(DbContextOptions<PersonelDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PersonelDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.PersonelId);

                entity.Property(e => e.PersonelId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(10);
            });
        }
    }
}
