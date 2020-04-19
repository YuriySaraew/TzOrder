using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TzOrders.Models
{
    public class Citie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public IEnumerable<Contragent> Contragents { get; set; }
    }
}
