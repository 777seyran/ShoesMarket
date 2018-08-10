using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFDeliveryTypeRepository:IDeliveryTypeRepository
    {
        private ShoesAppDbContext context;
        public EFDeliveryTypeRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<DeliveryType> DeliveryTypes => context.DeliveryTypes;                
    }
}
