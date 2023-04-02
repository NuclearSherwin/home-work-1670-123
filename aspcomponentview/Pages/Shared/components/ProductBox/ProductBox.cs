using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace Phong
{
    // [ViewComponent]
    public class ProductBox : ViewComponent
    {
        ProductListService _productsService;

        public ProductBox(ProductListService productsService)
        {   
            _productsService = productsService;
        }

        public IViewComponentResult Invoke(bool sapxeptangdan = true)
        {
            

            List<Product> sortedProducts = null;

            if (sapxeptangdan) {
                sortedProducts = _productsService.products.OrderBy(p => p.Price).ToList();
            }
            else {
                sortedProducts = _productsService.products.OrderByDescending(p => p.Price).ToList();
            }
            
            return View<List<Product>>(sortedProducts);
        } 
    }
}