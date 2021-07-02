using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalara.StateSalesTax.Domain.DomainEntities
{
    public class ZipCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CityName { get; set; }
        public int FipsJurisdictionCodeId { get; set; }
        public FipsJurisdictionCode FipsJurisdictionCode { get; set; }
    }
}
