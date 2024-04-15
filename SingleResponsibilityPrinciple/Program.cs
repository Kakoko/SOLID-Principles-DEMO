using SingleResponsibilityPrinciple;

List<Product> products = Product.GetProducts();

foreach (var product in products)
{
    if (product.IsValid())
    {
        Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
    }
    else
    {
        Console.WriteLine($"Error: Invalid product data for {product.Name}");
    }
}