using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Phong;

namespace aspcomponentview.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost()
        {
            var username = this.Request.Form["username"];
            var message = new MessagePage.Message();
            message.Title = "Thong Bao";
            message.htmlContent = $"Thank you {username} for submit"; 
            message.secondwait= 3;
            message.urlRedirect = "/";
            return ViewComponent("MessagePage", message);
        }

        public void OnGet()
        {

        }
    }
}
