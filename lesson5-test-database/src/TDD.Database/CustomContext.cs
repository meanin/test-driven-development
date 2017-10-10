using System.Data.Entity;
using TDD.Database.DbModels;

namespace TDD.Database
{   /// <summary>
    /// 1. Enable-Migrations from pmc
    /// 2. Add-Migration Init
    /// 3. Update-Database
    /// </summary>
    public class CustomContext : DbContext
    {
        public CustomContext(string connectionString)
            : base(connectionString)
        {
            Database.CreateIfNotExists();
        }

        public DbSet<CustomType> CustomTypes { get; set; }
    }
}
