using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Domain.DomainEntities.Interfaces.Fips;

namespace Avalara.StateSalesTax.Domain.DomainEntities
{
    public class FipsJurisdictionCode : IFipsCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<TaxRate> TaxRates { get; set; }
        public ICollection<ZipCode> ZipCodes { get; set; }
    }
}
