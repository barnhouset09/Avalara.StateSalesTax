using System;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Avalara.StateSalesTax.Service.ServicesLibrary.TestHelpers.BaseClasses
{
    public class DbContextDependentBase : IDisposable
    {
        private readonly StateSalesTaxDbContext _DbContext;

        public DbContextDependentBase(StateSalesTaxDbContext dbContext)
        {
            _DbContext = dbContext;

            // Seed the in-memory database, keep the connection open (it will be removed/deleted from memory when closed).
            // This allows us to keep an alive, fully seeded database in memory.
            _DbContext.Database.OpenConnection();
            _DbContext.Database.Migrate();
        }

        public void Dispose()
        {
            // Close the connection, which should delete the database entirely.
            _DbContext.Database.CloseConnection();
        }
    }
}
