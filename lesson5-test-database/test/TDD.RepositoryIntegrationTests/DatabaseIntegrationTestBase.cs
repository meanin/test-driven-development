using System;
using System.Data.Entity;

namespace TDD.RepositoryIntegrationTests
{
    public abstract class DatabaseIntegrationTestBase : IDisposable
    {
        protected readonly DbContext Context;

        protected DatabaseIntegrationTestBase(DbContext context)
        {
            Context = context;
        }

        public void Dispose()
        {
            Context.Database.Connection.Close();
            Context.Database.Delete();
            Context?.Dispose();
        }
    }
}
