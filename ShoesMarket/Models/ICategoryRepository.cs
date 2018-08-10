using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }
    }
}
