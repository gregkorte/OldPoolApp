using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PoolApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Manufacturer { get; set; }
        public string ProductNumber { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string ProductLine { get; set; }
        public string Upc { get; set; }
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }

        public virtual Invoice Invoices { get; set; }

        public Product()
        {

        }

        public Product(string Name, string Company, string Manufacturer, string ProductNumber, string ManufacturerPartNumber, string UnitOfMeasurement, string Description, string Department, string ProductLine, string Upc, decimal Cost, string ImageUrl)
        {
            this.Name = Name;
            this.Company = Company;
            this.Manufacturer = Manufacturer;
            this.ProductNumber = ProductNumber;
            this.ManufacturerPartNumber = ManufacturerPartNumber;
            this.UnitOfMeasurement = UnitOfMeasurement;
            this.Description = Description;
            this.Department = Department;
            this.ProductLine = ProductLine;
            this.Upc = Upc;
            this.Cost = Cost;
            this.ImageUrl = ImageUrl;
        }
    }
}