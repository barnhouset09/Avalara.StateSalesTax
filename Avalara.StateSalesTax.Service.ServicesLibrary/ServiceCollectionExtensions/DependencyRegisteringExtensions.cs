using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Domain.Constants;
using Avalara.StateSalesTax.Service.Contracts;
using Avalara.StateSalesTax.Service.ServicesLibrary.AutoMapperProfiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Avalara.StateSalesTax.Service.ServicesLibrary.ServiceCollectionExtensions
{
    public static class DependencyRegisteringExtensions
    {
        public static IServiceCollection RegisterServiceLibraryDependencies(this IServiceCollection services, bool isForUnitTests = false)
        {
            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(TaxRateProfile).Assembly);
            });

            // SINGLETONS - Add services that only require one instance of themselves per application (usually those not needing scoped dependencies, like static configuration data).
            services.AddSingleton<IConfigurationProvider>(autoMapperConfig);

            // TRANSIENTS - Add services that need to be re-instantiated due to scoping or other similar requirements (usually those dependent on DbContexts or File IO).
            services.AddTransient<ITaxRateDataService, TaxRateDataService>();
            services.AddTransient<ITaxCalculationService, TaxCalculationService>();
            services.AddTransient<IRetailTransactionTaxCalculationService, RetailTransactionTaxCalculationService>();
            services.AddTransient<IRetailTransactionItemRateSelectionService, RetailTransactionItemRateSelectionService>();

            // DBCONTEXTS - These guys are special services due to how complicated EF can get in terms of transaction scopes and all the other
            // rules and concepts applied within the framework. Just let .NET handle it (thankfully they've got stuff available in .NET core to handle all of it).
            // Note: Interestingly enough, actual SQL transaction scopes aren't handled by EF Core yet. I recommend the Mehdime package to handle transactions, but
            // some extra work needs to be done to make it work but I highly recommend it to do unit-of-work style of services with EF.
            //
            // It would take me a bit more time to come up with a solution using it than this coding exercise would allow for (I've only set it up for older versions of EF before Core).
            //
            // Unit tests use an in-memory database instead of the default Sqlite setup this application relies on.
            if (!isForUnitTests)
            {
                var dbFileTemporaryPathLocation = $"{Path.GetTempPath()}{ProjectConstants.DatabaseTempFileSubPath}";
                var dbFileTempDirectory = $"{Path.GetTempPath()}{ProjectConstants.DatabaseTempPathSubfolderName}";

                // For some reason the SQLLite nuget package stuff cannot create directories in the temp directory, at least on windows.
                // This will bypass the error this causes (on windows, at least).
                try
                {
                    if (!Directory.Exists(dbFileTempDirectory))
                    {
                        Directory.CreateDirectory(dbFileTempDirectory);
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }

                services.AddDbContext<StateSalesTaxDbContext>(options => options.UseSqlite($"Data Source={dbFileTemporaryPathLocation}"));
            }
            return services;
        }
    }
}
