using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ModernProducts.Models;
using ModernProducts.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Migrate DB on startup
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<ProductDbContext>();
        db.Database.Migrate();

        if (!db.Products.Any())
        {
            db.Products.AddRange(
                new Product { Name = "Laptop", Price = 999.99m },
                new Product { Name = "Mouse", Price = 25.50m }
            );
            db.SaveChanges();
        }
    }
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();