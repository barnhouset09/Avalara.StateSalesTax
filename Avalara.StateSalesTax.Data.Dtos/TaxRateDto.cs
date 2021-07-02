using System;

namespace Avalara.StateSalesTax.Data.Dtos
{
    public class TaxRateDto
    {
        /// <summary>
        /// The database record ID of the TaxRate.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The State in which the tax rate applies.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The FIPs Tax Rate Jurisdiction Type.
        /// </summary>
        public string TaxRateType { get; set; }

        /// <summary>
        /// The County of the given Tax Rate.
        /// </summary>
        public string County { get; set; }
        public double GeneralIntrastateRate { get; set; }
        public double GeneralInterstateRate { get; set; }
        public double FoodDrugIntrastateRate { get; set; }
        public double FoodDrugInterstateRate { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
