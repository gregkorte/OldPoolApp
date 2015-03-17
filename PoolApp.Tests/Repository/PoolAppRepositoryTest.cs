using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolApp.Repository;
using PoolApp;
using PoolApp.Models;


namespace PoolApp.Tests.Repository
{
    /// <summary>
    /// PoolAppRepositoryTesting
    /// </summary>

    [TestClass]
    class PoolAppRepositoryTest
    {
        private static CustomerRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new CustomerRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }

        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [TestMethod]
        public void AddCustomerToDb()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Customer("Monday", "Maxwell", "Edison", "1969 Abbey Rd", "Liverpool", "TN", "37685", "615-809-0987", "edisonm@silverhammer.com", "Majoring in medicine, sneaks up from behind."));
            Assert.AreEqual(1, repo.GetCount());
        }
    }
}
