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
    public class ServiceModelTest
    {
        [TestMethod]
        public void CreatingAnServiceStoresItsProperties()
        {
            Service service = new Service("Regular Cleaning", 45, "Week");
            Assert.AreEqual("Regular Cleaning", service.Name);
            Assert.AreEqual(45, service.Cost);
            Assert.AreEqual("Week", service.WorkUnit);
        }
    }
}
