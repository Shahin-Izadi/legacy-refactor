using System;
using System.Collections.Generic;
using System.Web.UI;

namespace LegacyWebForms
{
    public partial class Products : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProducts();
            }
        }

        private void BindProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop Pro 15", Category = "Electronics", Price = 1299.99m, Stock = 45 },
                new Product { Id = 2, Name = "Wireless Mouse", Category = "Accessories", Price = 39.99m, Stock = 123 },
                new Product { Id = 3, Name = "Mechanical Keyboard", Category = "Accessories", Price = 149.99m, Stock = 67 },
                new Product { Id = 4, Name = "4K Monitor 27\"", Category = "Electronics", Price = 499.99m, Stock = 23 },
                new Product { Id = 5, Name = "USB-C Hub", Category = "Accessories", Price = 79.99m, Stock = 189 }
            };

            GridView1.DataSource = products;
            GridView1.DataBind();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}