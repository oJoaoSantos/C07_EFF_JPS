namespace D04_EF6_Migrations_DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<D04_EF6_Migrations_DAL.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(D04_EF6_Migrations_DAL.BookDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.DaweyDecimalClassification.AddOrUpdate(i => i.DaweyDecimalClassificationID,
                new DaweyDecimalClassification
                {
                    DDCCode = "000",
                    DDCClassification = "Computer science, information and general works"
                });

            context.DaweyDecimalClassification.AddOrUpdate(i => i.DaweyDecimalClassificationID,
               new DaweyDecimalClassification
               {
                   DDCCode = "100",
                   DDCClassification = "Philosophy and psychology"
               });
            context.DaweyDecimalClassification.AddOrUpdate(i => i.DaweyDecimalClassificationID,
              new DaweyDecimalClassification
              {
                  DDCCode = "200",
                  DDCClassification = "Religion"
              });
        }
    }
}
