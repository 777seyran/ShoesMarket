using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFDelieveryRepository : IDelieveryRepository
    {
        private ShoesAppDbContext context;
        public EFDelieveryRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<Delievery> Deliveries => context.Delieveries;
    }
}
