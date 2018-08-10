using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public interface IBrandRepository
    {
        IQueryable<Brand> Brands { get; }
    }
}
