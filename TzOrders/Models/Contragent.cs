using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TzOrders.Models
{
    public class Contragent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CitieId { get; set; }

        public Citie Citie { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
