﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PoolApp.Models;

namespace PoolApp.Repository
{
    public interface IInvoiceRepository
    {
        int GetCount();
        void Add(Invoice I);
        void Delete(Invoice I);
        void Clear();
        //int CalculateTotal();
        //IEnumerable<Invoice> All();
        //Invoice GetById(int id);
        //Invoice GetByDate(string Date);
        //IQueryable<Invoice> SearchFor(Expression<Func<Invoice, bool>> predicate);
    }
}