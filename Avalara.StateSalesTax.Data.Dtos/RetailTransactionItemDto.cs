using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalara.StateSalesTax.Data.Dtos
{
    public class RetailTransactionItemDto
    {
        public string ItemName { get; set; }
        public double PurchasePrice { get; set; }
        public bool IsFoodOrDrugItem { get; set; }
        public bool IsInterstatePurchase { get; set; }
    }
}
