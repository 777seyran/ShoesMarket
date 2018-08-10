using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFBrandRepository:IBrandRepository
    {
        private ShoesAppDbContext context;
        public EFBrandRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<Brand> Brands => context.Brands;
    }
}
