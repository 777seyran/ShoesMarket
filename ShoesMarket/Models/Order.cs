using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class Order
    {
        public int OrderId { get; set; }
       
        [Required]
        public Product Product { get; set; }
        [Required]
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
    }
}
