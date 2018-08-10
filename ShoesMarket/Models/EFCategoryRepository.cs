using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFCategoryRepository:ICategoryRepository
    {
        private ShoesAppDbContext context;
        public EFCategoryRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<Category> Categories => context.Categories;
    }
}
