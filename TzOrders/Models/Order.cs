using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TzOrders.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime Created { get; set; }

        [ForeignKey("Contragent")]
        public int? ContragentId { get; set; }

        [ForeignKey("Contact")]
        public int? ContactId { get; set; }

        public int? ResContactId { get; set; }
        

        
        public Contragent Contragent { get; set; }
        public Contact Contact { get; set; }
        public Contact ResContact { get; set; }
    }
}
