using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Domain.DomainEntities;

namespace Avalara.StateSalesTax.Service.ServicesLibrary.AutoMapperProfiles
{
    public class TaxRateProfile : Profile
    {
        public TaxRateProfile()
        {
            var map = CreateMap<TaxRate, TaxRateDto>();

            map.ForMember(m => m.State, opt => opt.MapFrom(o => o.FipsStateCode.Description));
            map.ForMember(m => m.County, opt => opt.MapFrom(o => o.FipsJurisdictionCode.Description));
            map.ForMember(m => m.TaxRateType, opt => opt.MapFrom(o => o.FipsJurisdictionTypeCode.Description));
        }
    }
}
