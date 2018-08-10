using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public Brand Brand{ get; set; }
        public int Stars { get; set; }
        public Size Size { get; set; }
        
        public decimal Discount { get; set; }
        public byte[] Image { get; set; }
        public byte[] SmallImage { get; set; }
    }
}
