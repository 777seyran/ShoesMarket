using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class EFCustomerRepository:ICustomerRepository
    {
        private ShoesAppDbContext context;
        public EFCustomerRepository(ShoesAppDbContext _context) { context = _context; }
        public IQueryable<Customer> Customers => context.Customers;
    }
}
