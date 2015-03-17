using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PoolApp.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string WorkUnit { get; set; }

        public virtual Invoice Invoices { get; set; }
    }
}