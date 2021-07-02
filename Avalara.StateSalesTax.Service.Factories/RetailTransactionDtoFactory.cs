using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Service.Contracts.Factories;

namespace Avalara.StateSalesTax.Service.Factories
{
    public class RetailTransactionDtoFactory : IRetailTransactionDtoFactory
    {
        public async Task<RetailTransactionDto> GetRetailTransactionDtoAsync()
        {
            var result = new RetailTransactionDto()
            {
                TransactionItems = new List<RetailTransactionItemDto>()
            };

            return result;
        }
    }
}
