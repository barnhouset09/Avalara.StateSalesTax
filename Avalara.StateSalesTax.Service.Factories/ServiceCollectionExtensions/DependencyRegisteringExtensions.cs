using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Service.Contracts;
using Avalara.StateSalesTax.Service.Contracts.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Avalara.StateSalesTax.Service.Factories.ServiceCollectionExtensions
{
    public static class DependencyRegisteringExtensions
    {
        public static IServiceCollection RegisterServiceFactoryDependencies(this IServiceCollection services)
        {
            // SINGLETONS - Add services that only require one instance of themselves per application (usually those not needing scoped dependencies, like static configuration data).
            services.AddSingleton<IRetailTransactionDtoFactory, RetailTransactionDtoFactory>();
            services.AddSingleton<ICalculatedTaxResponseDtoFactory, CalculatedTaxResponseDtoFactory>();

            // TRANSIENTS - Add services that need to be re-instantiated due to scoping or other similar requirements (usually those dependent on DbContexts or File IO).
            // None needed for this library yet.

            // DBCONTEXTS - These guys are special services due to how complicated EF can get in terms of transaction scopes and all the other
            // rules and concepts applied within the framework. Just let .NET handle it (thankfully they've got stuff available in .NET core to handle all of it).
            // Note: Interestingly enough, actual SQL transaction scopes aren't handled by EF Core yet. I recommend the Mehdime package to handle transactions, but
            // some extra work needs to be done to make it work but I highly recommend it to do unit-of-work style of services with EF.
            //
            // It would take me a bit more time to come up with a solution using it than this coding exercise would allow for (I've only set it up for older versions of EF before Core).
            // None needed for this library yet.

            return services;
        }
    }
}
