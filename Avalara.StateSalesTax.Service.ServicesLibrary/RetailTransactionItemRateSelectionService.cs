using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Service.Contracts;

namespace Avalara.StateSalesTax.Service.ServicesLibrary
{
    public class RetailTransactionItemRateSelectionService : IRetailTransactionItemRateSelectionService
    {
        public async Task<double> GetTaxRateAsync(RetailTransactionItemDto transactionItem, TaxRateDto taxRate)
        {
            // If is an interstate purchase, use interstate rates.
            if (transactionItem.IsInterstatePurchase)
            {
                // If is a food or drug item, use the food/drug rate.
                if (transactionItem.IsFoodOrDrugItem)
                {
                    return taxRate.FoodDrugInterstateRate;
                }
                // If not, use the general rate.
                else
                {
                    return taxRate.GeneralInterstateRate;
                }
            }
            // If is an intrastate purchase, use intrastate rates.
            else
            {
                // If is a food or drug item, user the food/drug rate.
                if (transactionItem.IsFoodOrDrugItem)
                {
                    return taxRate.FoodDrugIntrastateRate;
                }
                // If not, use the general rate.
                else
                {
                    return taxRate.GeneralIntrastateRate;
                }
            }
        }
    }
}
