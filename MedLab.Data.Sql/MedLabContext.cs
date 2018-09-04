using MedLab.Core.Models;
using System.Data.Entity;

namespace MedLab.Data.Sql
{
    public class MedLabContext : DbContext
    {
        public MedLabContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<MedTest> MedTests { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedTest>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MedTest>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PercentDiscount)
                .HasPrecision(5, 2);
        }
    }
}
