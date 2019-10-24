using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lesson5App1.Models
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

        public static readonly Microsoft.Extensions.Logging.LoggerFactory _myLoggerFactory = new Microsoft.Extensions.Logging.LoggerFactory(new[] { new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider() });


        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PersonelDB;Trusted_Connection=True;");
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.PersonelId);

                entity.Property(e => e.PersonelId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(10);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__Employees__JobId__6FE99F9F");
                    
                    
            });



            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.Property(e => e.JobId).ValueGeneratedNever();

                entity.Property(e => e.JobTitle).HasMaxLength(20);

                entity.HasMany(e=>e.Employees)
                      .WithOne(j=>j.Job)
                      .HasForeignKey(e=>e.JobId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);
            });
            
        }
    }
}
