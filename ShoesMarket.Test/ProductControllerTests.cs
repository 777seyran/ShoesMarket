﻿using Moq;
using ShoesMarket.Controllers;
using ShoesMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ShoesMarket.Test
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
new Product {ProductId = 1, Name = "P1"},
new Product {ProductId = 2, Name = "P2"},
new Product {ProductId = 3, Name = "P3"},
new Product {ProductId = 4, Name = "P4"},
new Product {ProductId = 5, Name = "P5"}
}).AsQueryable<Product>());
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;
            // Act
            IEnumerable<Product> result =
            controller.List("",2).ViewData.Model as IEnumerable<Product>;
            // Assert
            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }
    }
}
