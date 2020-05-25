namespace StoreApplication.Migrations.Store
{
    using StoreApplication.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StoreApplication.Data.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Store";
        }

        protected override void Seed(StoreApplication.Data.StoreContext context)
        {
            context.Products.AddOrUpdate(
                p => p.ProductID, DummyData.getProducts().ToArray());
            context.SaveChanges();
        }
    }
}
