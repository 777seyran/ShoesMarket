using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class Delievery
    {
        public int DelieveryId { get; set; }
        public Order Order { get; set; }
        public DateTime DelieveryDate { get; set; }
        public decimal Price { get; set; }
        public DeliveryStatus Status { get; set; }
        public DeliveryType DelieveryType { get; set; }
    }
}
