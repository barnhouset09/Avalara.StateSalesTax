using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalara.StateSalesTax.Data.Dtos
{
    public class CalculatedTaxResponseBreakdownItemDto
    {
        public string TransactionItemName { get; set; }
        public double TransactionItemPreTaxPrice { get; set; }
        public string TaxType { get; set; }
        public double TaxRate { get; set; }
        public double TaxAmount { get; set; }
    }
}
