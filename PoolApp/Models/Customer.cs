using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PoolApp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string RouteDay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public Customer()
        {

        }

        public Customer(string RouteDay, string FirstName, string LastName, string Address, string City, string State, string Zipcode, string Phone, string Email, string Notes)
        {
            this.RouteDay = RouteDay;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.Phone = Phone;
            this.Email = Email;
            this.Notes = Notes;
        }
    }
}