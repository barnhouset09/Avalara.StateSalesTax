using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Domain.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avalara.StateSalesTax.Data.EntityFramework.EntityTypeConfigurations
{
    public class FipsStateCodeEntityTypeConfiguration : IEntityTypeConfiguration<FipsStateCode>
    {
        public void Configure(EntityTypeBuilder<FipsStateCode> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.TaxRates);

            #region SEED DATA
            builder.HasData(new List<FipsStateCode>()
            {
                new FipsStateCode()
                {
                    Id = 1,
                    Code = "37",
                    Description = "North Carolina"
                }
            });
            #endregion
        }
    }
}
