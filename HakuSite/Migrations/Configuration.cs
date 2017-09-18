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
            //      new Employee { FullName = "Andrew Peters" },
            //      new Employee { FullName = "Brice Lambson" },
            //      new Employee { FullName = "Rowan Miller" }
            //    );
            //


            //context.Employees.AddOrUpdate(i => i.ID,
            //new Employee
            //{
            //    Name = "haku",
            //    Org = "ABC",
            //    Phone = "123",
            //},
            //new Employee
            //{
            //    Name = "chihiro",
            //    Org = "ABC",
            //    Phone = "987",
            //},
            //new Employee
            //{
            //    Name = "moe",
            //    Org = "ABC",
            //    Phone = "456",
            //});

            //context.Orgs.AddOrUpdate(i => i.ID,
            //    new Org
            //    {
            //        OrgID = "O-123",
            //        OrgName = "ORG-123",
            //    });

        }
    }
}
