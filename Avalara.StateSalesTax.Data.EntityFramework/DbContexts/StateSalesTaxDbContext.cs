using System;
using System.IO;
using Avalara.StateSalesTax.Data.EntityFramework.EntityTypeConfigurations;
using Avalara.StateSalesTax.Domain.Constants;
using Avalara.StateSalesTax.Domain.DomainEntities;
using Microsoft.EntityFrameworkCore;

namespace Avalara.StateSalesTax.Data.EntityFramework.DbContexts
{
    public class StateSalesTaxDbContext : DbContext
    {
        
        public DbSet<FipsStateCode> FipsStateCodes { get; set; }
        public DbSet<FipsJurisdictionTypeCode> FipsJurisdictionTypeCodes { get; set; }
        public DbSet<FipsJurisdictionCode> FipsJurisdictionCodes { get; set; }
        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }

        public StateSalesTaxDbContext()
        {

        }

        public StateSalesTaxDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(TaxRateEntityTypeConfiguration).Assembly);
        }
            
    }
}
