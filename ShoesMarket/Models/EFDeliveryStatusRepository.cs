using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFDeliveryStatusRepository:IDeliveryStatusRepository
    {
        private ShoesAppDbContext context;
        public EFDeliveryStatusRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<DeliveryStatus> DeliveryStatuses => context.DeliveryStatuses;
    }
}
