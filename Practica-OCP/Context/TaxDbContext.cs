using Microsoft.EntityFrameworkCore;
using Practica_OCP.Entities;

namespace Practica_OCP.Context
{


    public class TaxDbContext : DbContext
    {
        public TaxDbContext(DbContextOptions<TaxDbContext> options)
            : base(options)
        {
        }
        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<TaxCalculation> TaxCalculations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaxRate>()
                .HasIndex(tr => tr.Country);

            modelBuilder.Entity<TaxCalculation>()
                .HasIndex(tc => tc.Country);
        }
    }
}
