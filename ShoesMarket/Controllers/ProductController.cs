using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoesMarket.Models;
using ShoesMarket.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoesMarket.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repo;
        public int PageSize = 3;
        // GET: /<controller>/
        public ProductController(IProductRepository _repo)
        {
            repo = _repo;
        }
        public ViewResult List(string category,int productPage = 1) => View(new ProductsListViewModel
        {
            Products = repo.Products
            .Where(p => category == null || p.Category.Name== category)
            .OrderBy(p => p.ProductId).Skip((productPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                repo.Products.Count() :
                repo.Products.Where(e =>
                e.Category.Name == category).Count()
            },
            CurrentCategory = category
        });
    }
}
