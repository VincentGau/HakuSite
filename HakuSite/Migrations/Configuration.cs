namespace HakuSite.Migrations
{
    using HakuSite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HakuSite.Models.HakuDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HakuSite.Models.HakuDBContext";
        }

        protected override void Seed(HakuSite.Models.HakuDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Persons.AddOrUpdate(i => i.ID,
                new Person
                {
                    name = "haku",
                    org = "ABC",
                    phone = "123",
                },
                new Person
                {
                    name = "chihiro",
                    org = "ABC",
                    phone = "987",
                },
                new Person
                {
                    name = "moe",
                    org = "ABC",
                    phone = "456",
                });

        }
    }
}
