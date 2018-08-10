using Microsoft.AspNetCore.Mvc;
using ShoesMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private IProductRepository repository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
            .Select(x => x.Category.Name)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
