﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PoolApp.Models;

namespace PoolApp.Repository
{
    public interface IServiceRepository
    {
        int GetCount();
        void Add(Service S);
        void Delete(Service S);
        void Clear();
        //int CalculateTotal();
        //IEnumerable<Invoice> All();
        //Invoice GetById(int id);
        //Invoice GetByDate(string Date);
        //IQueryable<Invoice> SearchFor(Expression<Func<Invoice, bool>> predicate);
    }
}