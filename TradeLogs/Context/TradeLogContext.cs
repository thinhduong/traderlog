using System.Data.Entity;
using TradeLogs.Model;

namespace TradeLogs.Context
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class TradeLogContext : DbContext
    {
        public TradeLogContext() : base("MyDB")
        {
            Database.SetInitializer(new TradeLogDbInitializer());
        }

        public DbSet<TradeLog> TradeLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    public class TradeLogDbInitializer : CreateDatabaseIfNotExists<TradeLogContext>
    {
    }
}
