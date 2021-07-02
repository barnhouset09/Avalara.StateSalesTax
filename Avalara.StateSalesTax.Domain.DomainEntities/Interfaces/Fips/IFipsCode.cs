using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalara.StateSalesTax.Domain.DomainEntities.Interfaces.Fips
{
    public interface IFipsCode
    {
        int Id { get; set; }
        string Code { get; set; }
        string Description { get; set; }
    }
}
