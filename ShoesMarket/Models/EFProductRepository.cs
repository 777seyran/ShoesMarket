using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ShoesAppDbContext context;
        public EFProductRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<Product> Products => context.Products;
    }
}
