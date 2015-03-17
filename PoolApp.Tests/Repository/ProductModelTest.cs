using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoolApp.Models;

namespace PoolApp.Tests.Repository
{
    [TestClass]
    public class ProductModelTest
    {
        [TestMethod]
        public void CreatingAnProductStoresItsProperties()
        {
            Product product = new Product("Chlorine Tabs", "ChemCo", "ChemCo", "90888", "90888", "tab", "Chlorine tablets", "Chemicals", "Chlorine", "0394809384093", 2, "https://image.poolcorp.com/images/CLU/50/CLU-50-5026_s.jpg");
            Assert.AreEqual("Chlorine Tabs", product.Name);
            Assert.AreEqual("ChemCo", product.Company);
            Assert.AreEqual("ChemCo", product.Manufacturer);
            Assert.AreEqual("90888", product.ProductNumber);
            Assert.AreEqual("90888", product.ManufacturerPartNumber);
            Assert.AreEqual("tab", product.UnitOfMeasurement);
            Assert.AreEqual("Chlorine tablets", product.Description);
            Assert.AreEqual("Chemicals", product.Department);
            Assert.AreEqual("Chlorine", product.ProductLine);
            Assert.AreEqual("0394809384093", product.Upc);
            Assert.AreEqual(2, product.Cost);
            Assert.AreEqual("https://image.poolcorp.com/images/CLU/50/CLU-50-5026_s.jpg", product.ImageUrl);
        }
    }
}
