using Microsoft.AspNetCore.Mvc;

namespace Phong
{
    public class MessagePage : ViewComponent
    {
        public class Message 
        {
            public string Title {get;set;} = "Thong Bao";
            public string htmlContent {get;set;} = "";
            public string urlRedirect {get;set;} = "/";
            public int secondwait {get;set;} = 3;
        }
        public MessagePage() {}
        public IViewComponentResult Invoke(Message message) {
            this.HttpContext.Response.Headers.Add("REFRESH", $"{message.secondwait};URL={message.urlRedirect}");
            return View(message);    
        }
    }
}