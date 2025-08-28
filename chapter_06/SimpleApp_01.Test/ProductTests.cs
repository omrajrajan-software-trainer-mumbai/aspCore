using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp_01.Models;
using Xunit;

namespace SimpleApp_01.Test
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductName()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };
            // Act
            p.Name = "New Name";
            //Assert
            Assert.Equal("New Name", p.Name);
        }

        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };
            // Act
            p.Price = 200M;
            //Assert
            Assert.Equal(100M, p.Price);
        }
    }
}
