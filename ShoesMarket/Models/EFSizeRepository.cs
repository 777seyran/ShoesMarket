using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFSizeRepository : ISizeRepository
    {
        private ShoesAppDbContext context;
        public EFSizeRepository(ShoesAppDbContext _context) { context = _context; }        
        public IQueryable<Size> Sizes => throw new NotImplementedException();
    }
}
