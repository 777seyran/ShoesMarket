using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFOrderRepository:IOrderRepository
    {
        private ShoesAppDbContext context;
        public EFOrderRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<Order> Orders => context.Orders;
    }
}
