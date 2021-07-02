using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Service.Factories.ServiceCollectionExtensions;
using Avalara.StateSalesTax.Service.ServicesLibrary.ServiceCollectionExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Avalara.StateSalesTax.Service.ServicesLibrary.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterServiceFactoryDependencies();
            services.RegisterServiceLibraryDependencies(true);

            services.AddDbContext<StateSalesTaxDbContext>(options => options.UseSqlite("Data Source=:memory:"));
        }
    }
}
