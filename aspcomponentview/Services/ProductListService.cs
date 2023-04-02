using System.Collections.Generic;

namespace Phong
{
    public class ProductListService
    {
        public List<Product> products {get;set;} = new List<Product>() {
                new Product() {Name = "SP 1", Description = "Mo ta cho SP 1", Price = 33},
                new Product() {Name = "SP 2", Description = "Mo ta cho SP 2", Price = 22},
                new Product() {Name = "SP 3", Description = "Mo ta cho SP 3", Price = 42},
                new Product() {Name = "SP 4", Description = "Mo ta cho SP 4", Price = 112},
            }; 
    }
}