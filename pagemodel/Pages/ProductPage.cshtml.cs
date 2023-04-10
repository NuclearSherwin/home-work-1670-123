using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace pagemodele.Pages
{
    public class ProductPageModel : PageModel
    {
        private readonly ProductService _productService; 
        private readonly ILogger<ProductPageModel> _logger;
        public ProductPageModel(ILogger<ProductPageModel> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public Product product {get;set;}
        public void OnGet(int? id, [Bind("Id", "Name")] Product product)
        {
            System.Console.WriteLine($"ID: {product.Id}");
            System.Console.WriteLine($"ID: {product.Name}");


            var data = this.Request.Query["id"];
            if (!string.IsNullOrEmpty(data)) 
            {
                System.Console.WriteLine(data.ToString());
                int i = int.Parse(data.ToString());
            }

            if (id != null) {
                ViewData["Title"] = $"San pham (ID = {id.Value})";
                product = _productService.Find(id.Value);
            }
            else {
                ViewData["Title"] = "Vi du trang san pham";
            }
            
        }

        public void OnGetLastProduct()
        {
            ViewData["Title"] = $"San pham cuoi";
            product = _productService.AllProducts().LastOrDefault();
        }

        public IActionResult OnGetRemoveAll()
        {
            _productService.AllProducts().Clear();
            return RedirectToPage("ProductPage");
        }

         public IActionResult OnGetLoad()
        {
            _productService.LoadProducts();
            return RedirectToPage("ProductPage");
        }

        public IActionResult OnPostDelete(int? id)
        {
            if (id != null)
            {
                product = _productService.Find(id.Value);
                if (product != null) {
                    _productService.AllProducts().Remove(product);
                }
            }

            return this.RedirectToPage("ProductPage", new {id = string.Empty});
        }
    }
}
