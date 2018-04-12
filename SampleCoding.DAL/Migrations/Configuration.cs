using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCoding.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SampleCodingDBContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SampleCodingDBContext";
        }

        protected override void Seed(SampleCodingDBContext context)
        {

            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.

            //  context.People.AddOrUpdate(
            //  p ⇒ p.FullName, 
            //  new Person { FullName = "Andrew Peters" }, 
            //  new Person { FullName = "Brice Lambson" }, 
            //  new Person { FullName = "Rowan Miller" }
            //  );
        }
    }
}
