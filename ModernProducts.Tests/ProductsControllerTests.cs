using ModernProducts.Controllers;
using ModernProducts.Data;
using ModernProducts.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

public class ProductsControllerTests
{
    [Fact]
    public async Task Index_ReturnsAllProducts()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
            .UseInMemoryDatabase("TestDb")
            .Options;

        await using var context = new ProductDbContext(options);
        context.Products.AddRange(
            new Product { Name = "Test1", Price = 100 },
            new Product { Name = "Test2", Price = 200 }
        );
        await context.SaveChangesAsync();

        var controller = new ProductsController(context);

        // Act
        var result = await controller.Index();

        // Assert
        var viewResult = Assert.IsType<Microsoft.AspNetCore.Mvc.ViewResult>(result);
        var model = Assert.IsAssignableFrom<List<Product>>(viewResult.Model);
        Assert.Equal(2, model.Count);
    }
}