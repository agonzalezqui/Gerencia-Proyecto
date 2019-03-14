using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace TallerBilly.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<TallerBilly.Models.TallerBillyDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TallerBilly.Models.TallerBillyDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
