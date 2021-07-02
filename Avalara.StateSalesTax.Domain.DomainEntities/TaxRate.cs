using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalara.StateSalesTax.Domain.DomainEntities
{
    /*
     * All information regarding Fips and understanding it come from these docs:
     *      https://www.streamlinedsalestax.org/docs/default-source/technology/technology-guide-january-2021.pdf?sfvrsn=bd7d8cfe_4
     *      - AND -
     *      https://files.nc.gov/ncdor/documents/files/rate_and_boundary_database_info.pdf
     *
     * Tax rate data seeded from csv file provided from:
     *      https://www.ncdor.gov/documents/rate-database-2020q4
     */
    public class TaxRate
    {
        public int Id { get; set; }
        public int FipsStateCodeId { get; set; }
        public FipsStateCode FipsStateCode { get; set; }
        public int FipsJurisdictionTypeCodeId { get; set; }
        public FipsJurisdictionTypeCode FipsJurisdictionTypeCode { get; set; }
        public int? FipsJurisdictionCodeId { get; set; }
        public FipsJurisdictionCode FipsJurisdictionCode { get; set; }
        public double GeneralIntrastateRate { get; set; }
        public double GeneralInterstateRate { get; set; }
        public double FoodDrugIntrastateRate { get; set; }
        public double FoodDrugInterstateRate { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
