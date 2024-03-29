namespace PoolApp.Migrations
{
    using PoolApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PoolApp;

    internal sealed class Configuration : DbMigrationsConfiguration<PoolAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PoolAppDbContext context)
        {
            context.Customers.AddOrUpdate(c => c.Phone,
            new Customer
            {
                RouteDay = "Monday",
                FirstName = "Grimble",
                LastName = "Crumble",
                Address = "1967 Gates of Dawn Rd",
                City = "Piper",
                State = "TN",
                Zipcode = "34567",
                Phone = "615-987-0988",
                Email = "the_gnome@bigadventure.com",
                Notes = "He wears a scarlet tunic, a bluegreen hood, it looks quite good."
            },

            new Customer
            {
                RouteDay = "Tuesday",
                FirstName = "Arnold",
                LastName = "Layne",
                Address = "1965 Moonshine Ln",
                City = "Washing Line",
                State = "TN",
                Zipcode = "32459",
                Phone = "615-987-6543",
                Email = "babyblue@distortedview.net",
                Notes = "Has a strange hobby, collecting clothes..."
            }
            );

            context.Products.AddOrUpdate(p => p.Upc,
            new Product
            {
                Name = "Chlorine Tabs",
                Company = "ChemCo",
                Manufacturer = "ChemCo",
                ProductNumber = "90888",
                ManufacturerPartNumber = "90888",
                UnitOfMeasurement = "tab",
                Description = "Chlorine tablets",
                Department = "Chemicals",
                ProductLine = "Chlorine",
                Upc = "0394809384093",
                Cost = 2,
                ImageUrl = "https://image.poolcorp.com/images/CLU/50/CLU-50-5026_s.jpg"
            },

            new Product
            {
                Name = "Shock",
                Company = "Pools & Spas",
                Manufacturer = "Poolstyle",
                ProductNumber = "PSL-50-1373",
                ManufacturerPartNumber = "C002983-CS20P5",
                UnitOfMeasurement = "bag",
                Description = "Pool Style 1lb Bag Multi Performance Shock {12/CS}",
                Department = "Chemicals",
                ProductLine = "Shock",
                Upc = "0394809384023",
                Cost = 23,
                ImageUrl = "https://image.poolcorp.com/images/PSL/50/PSL-50-1373_s.jpg"
            }
            );

            context.Services.AddOrUpdate(s => s.Name,
            new Service
            {
                Name = "Regular Cleaning",
                Cost = 45,
                WorkUnit = "Week"
            },

            new Service
            {
                Name = "One-Time Cleaning",
                Cost = 55,
                WorkUnit = "Per"
            }
            );
        }
    }
}
