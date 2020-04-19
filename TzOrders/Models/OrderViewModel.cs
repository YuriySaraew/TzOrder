using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TzOrders.Models;

namespace TzOrders.Models
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Contragent> Contragents { get; set; }
        public IEnumerable<Contact> Contacts{ get; set; }
        public IEnumerable<Citie> Cities { get; set; }
    }
}
