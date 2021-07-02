using System.Collections.Generic;

namespace Avalara.StateSalesTax.Data.Dtos
{
    public class RetailTransactionDto
    {
        public string ZipCode { get; set; }
        public List<RetailTransactionItemDto> TransactionItems { get; set; }
    }
}
