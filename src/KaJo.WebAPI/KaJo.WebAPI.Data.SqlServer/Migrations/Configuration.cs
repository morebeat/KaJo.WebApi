namespace KaJo.WebAPI.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KaJo.WebAPI.Data.SqlServer.BookStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "KaJo.WebAPI.Data.SqlServer.BookStoreContext";
        }

        protected override void Seed(KaJo.WebAPI.Data.SqlServer.BookStoreContext context)
        {
        }
    }
}
