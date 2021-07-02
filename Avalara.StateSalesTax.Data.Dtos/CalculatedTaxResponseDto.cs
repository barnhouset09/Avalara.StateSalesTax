using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalara.StateSalesTax.Data.Dtos
{
    public class CalculatedTaxResponseDto
    {
        public double TotalTaxAmount { get; set; }
        public List<CalculatedTaxResponseBreakdownItemDto> TaxBreakdown { get; set; }

    }
}
