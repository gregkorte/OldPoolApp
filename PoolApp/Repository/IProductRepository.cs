﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PoolApp.Models;

namespace PoolApp.Repository
{
    public interface IProductRepository
    {
        int GetCount();
        void Add(Product P);
        void Delete(Product P);
        void Clear();
        //int CalculateTotal();
        //IEnumerable<Invoice> All();
        //Invoice GetById(int id);
        //Invoice GetByDate(string Date);
        //IQueryable<Invoice> SearchFor(Expression<Func<Invoice, bool>> predicate);
    }
}