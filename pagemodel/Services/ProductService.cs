using System.Collections.Generic;
using System.Linq;

public class ProductService {
    private List<Product> products = new List<Product>();

    public ProductService()
    {
        LoadProducts();
    }

    public Product Find(int id) 
    {
        var result = from p in products
                     where p.Id == id select p;

        return result.FirstOrDefault();
    }

    // get all
    public List<Product> AllProducts() => products;

    public void LoadProducts()
    {
        products.Clear();

        products.Add(new Product()
        {
            Id = 1,
            Name = "Keyboard",
            Description = "Accessories",
            Price = 21
        });
        products.Add(new Product()
        {
            Id = 2,
            Name = "Salt",
            Description = "Additives",
            Price = 78
        });
        products.Add(new Product()
        {
            Id = 3,
            Name = "Fried fish",
            Description = "Foods",
            Price = 100
        });
    } 

    
}