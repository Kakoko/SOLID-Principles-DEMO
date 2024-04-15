using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { Id = 1, Name = "T-Shirt", Price = 19.99m, Description = "Comfortable cotton T-Shirt" },
                new Product { Id = 2, Name = "Coffee Mug", Price = 8.99m, Description = "The perfect mug for your morning coffee" }
            };
        }

        public bool IsValid()
        {
            return Price > 0 && !string.IsNullOrEmpty(Name);
        }
    }
}
