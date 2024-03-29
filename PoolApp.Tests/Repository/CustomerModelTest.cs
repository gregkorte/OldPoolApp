﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoolApp.Models;

namespace PoolApp.Tests.Repository
{
    [TestClass]
    public class CustomerModelTest
    {
        [TestMethod]
        public void CreatingAnCustomerStoresItsProperties()
        {
            Customer customer = new Customer("Monday", "Maxwell", "Edison", "1969 Abbey Rd", "Liverpool", "TN", "37685", "615-809-0987", "edisonm@silverhammer.com", "Majoring in medicine, sneaks up from behind.");
            Assert.AreEqual("Monday", customer.RouteDay);
            Assert.AreEqual("Maxwell", customer.FirstName);
            Assert.AreEqual("Edison", customer.LastName);
            Assert.AreEqual("1969 Abbey Rd", customer.Address);
            Assert.AreEqual("Liverpool", customer.City);
            Assert.AreEqual("TN", customer.State);
            Assert.AreEqual("37685", customer.Zipcode);
            Assert.AreEqual("615-809-0987", customer.Phone);
            Assert.AreEqual("edisonm@silverhammer.com", customer.Email);
            Assert.AreEqual("Majoring in medicine, sneaks up from behind.", customer.Notes);
        }
    }
}
