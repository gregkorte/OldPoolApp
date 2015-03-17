﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoolApp;
using System.Data.Entity;
using PoolApp.Models;

namespace PoolApp.Repository
{
    //---------------//
    // CUSTOMER REPO //
    //---------------//
    public class CustomerRepository : ICustomerRepository
    {
        private PoolAppDbContext _dbContext;

        public CustomerRepository()
        {
            _dbContext = new PoolAppDbContext();
            _dbContext.Customers.Load();
        }

        public PoolAppDbContext Context()
        {
            return _dbContext;
        }

        public DbSet<Models.Customer> GetDbSet()
        {
            return _dbContext.Customers;
        }

        public int GetCount()
        {
            return _dbContext.Customers.Count<Models.Customer>();

        }

        public void Add(Models.Customer C)
        {
            /* Solution 1:
             * Find if the event is in the DB;
             * 
             * var query = from Event in _dbContext.Events
             * where Event.Date == E.Date and Event.Name == E.Name
             * select Event;
             * 
             * if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Solution 2:
             * 
             * Migration on the table, adding another field. Like, a hash (Name+Date).
             * 
             * var gimme_hash = Sha1.Create(E.Name+E.Date);
             * gimme_hash.Hash;
             * _dbContext.Event.Find(e => e.Hash == E.hash);
             * _dbContext.Event.SingleOrDefault(e => e.Hash == E.hash);
             * OR use LINQ
             * 
             *if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Thinking forward, we want the UI window handling the Event addition to tell the user they
             * can't add duplicates
             * */
            _dbContext.Customers.Add(C);
            _dbContext.SaveChanges();
        }

        public void Delete(Models.Customer C)
        {
            _dbContext.Customers.Remove(C);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Customers.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.Customer> PastEvents()
        {
            throw new NotImplementedException();
        }

        public int CalculateTotal(Models.Customer C)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Customer> All()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            var qu = from Customer in _dbContext.Customers select Customer;
            return qu.ToList<Models.Customer>();
        }

        public Models.Customer GetById(int id)
        {
            var query = from Customer in _dbContext.Customers
                        where Customer.ID == id
                        select Customer;
            return query.First<Models.Customer>();

        }

        //public Models.Customer GetByDate(string date)
        //{
        //    var query = from Customer in _dbContext.Customers
        //                where Customer.Date == date
        //                select Customer;
        //    return query.First<Models.Customer>();
        //}

        public IQueryable<Models.Customer> SearchFor(System.Linq.Expressions.Expression<Func<Models.Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }

    //--------------//
    // PRODUCT REPO //
    //--------------//
    public class ProductRepository : IProductRepository
    {
        private PoolAppDbContext _dbContext;

        public ProductRepository(string connection = "PoolApp.ProductContext")
        {
            _dbContext = new PoolAppDbContext(connection);
            _dbContext.Products.Load();
        }

        public PoolAppDbContext Context()
        {
            return _dbContext;
        }

        public DbSet<Models.Product> GetDbSet()
        {
            return _dbContext.Products;
        }

        public int GetCount()
        {
            return _dbContext.Products.Count<Models.Product>();

        }

        public void Add(Models.Product P)
        {
            /* Solution 1:
             * Find if the event is in the DB;
             * 
             * var query = from Event in _dbContext.Events
             * where Event.Date == E.Date and Event.Name == E.Name
             * select Event;
             * 
             * if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Solution 2:
             * 
             * Migration on the table, adding another field. Like, a hash (Name+Date).
             * 
             * var gimme_hash = Sha1.Create(E.Name+E.Date);
             * gimme_hash.Hash;
             * _dbContext.Event.Find(e => e.Hash == E.hash);
             * _dbContext.Event.SingleOrDefault(e => e.Hash == E.hash);
             * OR use LINQ
             * 
             *if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Thinking forward, we want the UI window handling the Event addition to tell the user they
             * can't add duplicates
             * */
            _dbContext.Products.Add(P);
            _dbContext.SaveChanges();
        }

        public void Delete(Models.Product P)
        {
            _dbContext.Products.Remove(P);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Products.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.Product> PastEvents()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth(Models.Product P)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Product> All()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            var qu = from Product in _dbContext.Products select Product;
            return qu.ToList<Models.Product>();
        }

        public Models.Product GetById(int id)
        {
            var query = from Product in _dbContext.Products
                        where Product.ID == id
                        select Product;
            return query.First<Models.Product>();

        }

        //public Models.Product GetByDate(string date)
        //{
        //    var query = from Product in _dbContext.Products
        //                where Product.Date == date
        //                select Product;
        //    return query.First<Models.Product>();
        //}

        public IQueryable<Models.Product> SearchFor(System.Linq.Expressions.Expression<Func<Models.Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }

    //--------------//
    // SERVICE REPO //
    //--------------//
    public class ServiceRepository : IServiceRepository
    {
        private PoolAppDbContext _dbContext;

        public ServiceRepository(string connection = "PoolApp.CustomerContext")
        {
            _dbContext = new PoolAppDbContext(connection);
            _dbContext.Services.Load();
        }

        public PoolAppDbContext Context()
        {
            return _dbContext;
        }

        public DbSet<Models.Service> GetDbSet()
        {
            return _dbContext.Services;
        }

        public int GetCount()
        {
            return _dbContext.Services.Count<Models.Service>();

        }

        public void Add(Models.Service S)
        {
            /* Solution 1:
             * Find if the event is in the DB;
             * 
             * var query = from Event in _dbContext.Events
             * where Event.Date == E.Date and Event.Name == E.Name
             * select Event;
             * 
             * if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Solution 2:
             * 
             * Migration on the table, adding another field. Like, a hash (Name+Date).
             * 
             * var gimme_hash = Sha1.Create(E.Name+E.Date);
             * gimme_hash.Hash;
             * _dbContext.Event.Find(e => e.Hash == E.hash);
             * _dbContext.Event.SingleOrDefault(e => e.Hash == E.hash);
             * OR use LINQ
             * 
             *if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Thinking forward, we want the UI window handling the Event addition to tell the user they
             * can't add duplicates
             * */
            _dbContext.Services.Add(S);
            _dbContext.SaveChanges();
        }

        public void Delete(Models.Service S)
        {
            _dbContext.Services.Remove(S);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Services.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.Service> PastEvents()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth(Models.Service S)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Service> All()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            var qu = from Service in _dbContext.Services select Service;
            return qu.ToList<Models.Service>();
        }

        public Models.Service GetById(int id)
        {
            var query = from Service in _dbContext.Services
                        where Service.ID == id
                        select Service;
            return query.First<Models.Service>();

        }

        //public Models.Service GetByDate(string date)
        //{
        //    var query = from Service in _dbContext.Services
        //                where Service.Date == date
        //                select Service;
        //    return query.First<Models.Service>();
        //}

        public IQueryable<Models.Service> SearchFor(System.Linq.Expressions.Expression<Func<Models.Service, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }

    //--------------//
    // INVOICE REPO //
    //--------------//
    public class InvoiceRepository : IInvoiceRepository
    {
        private PoolAppDbContext _dbContext;

        public InvoiceRepository(string connection = "PoolApp.CustomerContext")
        {
            _dbContext = new PoolAppDbContext(connection);
            _dbContext.Invoices.Load();
        }

        public PoolAppDbContext Context()
        {
            return _dbContext;
        }

        public DbSet<Models.Invoice> GetDbSet()
        {
            return _dbContext.Invoices;
        }

        public int GetCount()
        {
            return _dbContext.Invoices.Count<Models.Invoice>();

        }

        public void Add(Models.Invoice I)
        {
            /* Solution 1:
             * Find if the event is in the DB;
             * 
             * var query = from Event in _dbContext.Events
             * where Event.Date == E.Date and Event.Name == E.Name
             * select Event;
             * 
             * if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Solution 2:
             * 
             * Migration on the table, adding another field. Like, a hash (Name+Date).
             * 
             * var gimme_hash = Sha1.Create(E.Name+E.Date);
             * gimme_hash.Hash;
             * _dbContext.Event.Find(e => e.Hash == E.hash);
             * _dbContext.Event.SingleOrDefault(e => e.Hash == E.hash);
             * OR use LINQ
             * 
             *if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Thinking forward, we want the UI window handling the Event addition to tell the user they
             * can't add duplicates
             * */
            _dbContext.Invoices.Add(I);
            _dbContext.SaveChanges();
        }

        public void Delete(Models.Invoice I)
        {
            _dbContext.Invoices.Remove(I);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Invoices.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.Invoice> PastEvents()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth(Models.Invoice I)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Invoice> All()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            var qu = from Invoice in _dbContext.Invoices select Invoice;
            return qu.ToList<Models.Invoice>();
        }

        public Models.Invoice GetById(int id)
        {
            var query = from Invoice in _dbContext.Invoices
                        where Invoice.ID == id
                        select Invoice;
            return query.First<Models.Invoice>();

        }

        public Models.Invoice GetByDate(string date)
        {
            var query = from Invoice in _dbContext.Invoices
                        where Invoice.Date.ToString() == date
                        select Invoice;
            return query.First<Models.Invoice>();
        }

        public IQueryable<Models.Invoice> SearchFor(System.Linq.Expressions.Expression<Func<Models.Invoice, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}