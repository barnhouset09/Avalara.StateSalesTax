using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Service.Contracts.Factories;

namespace Avalara.StateSalesTax.Service.Factories
{
    public class CalculatedTaxResponseDtoFactory : ICalculatedTaxResponseDtoFactory
    {
        public async Task<CalculatedTaxResponseDto> GetCalculatedTaxResponseDtoAsync()
        {
            var result = new CalculatedTaxResponseDto()
            {
                TaxBreakdown = new List<CalculatedTaxResponseBreakdownItemDto>()
            };

            return result;
        }

        public async Task<CalculatedTaxResponseBreakdownItemDto> GetCalculatedTaxResponseBreakdownItemDtoAsync()
        {
            var result = new CalculatedTaxResponseBreakdownItemDto();

            return result;
        }
    }
}
