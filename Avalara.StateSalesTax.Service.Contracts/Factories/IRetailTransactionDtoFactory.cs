using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;

namespace Avalara.StateSalesTax.Service.Contracts.Factories
{
    public interface IRetailTransactionDtoFactory
    {
        Task<RetailTransactionDto> GetRetailTransactionDtoAsync();
    }
}
