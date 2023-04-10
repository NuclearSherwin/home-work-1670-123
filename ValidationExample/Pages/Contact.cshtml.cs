using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ValidationExample.Pages
{
    public class ContactModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;

        public ContactModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
        public CustomerInfo customerInfo {get;set;}

        [BindProperty]
        [DataType(DataType.Upload)]
        // [Required(ErrorMessage = "Chon file upload")]
        [DisplayName("File upload")]
        [CheckFileExtension(Extensions = "jpg, png, gif")]
        public IFormFile FileUpload { get; set; }

        [BindProperty]
        [DataType(DataType.Upload)]
        [DisplayName("Upload multiple files")]
        public IFormFile[] FileUploads {get;set;}

        public void OnGet()
        {
            
        }

        public string message {get;set;}

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                message = "The submit form was send ís Valid";
                if (FileUpload != null)
                {
                    var filePath = Path.Combine(_environment.WebRootPath, "uploads", FileUpload.FileName);
                    using var fileStream = new FileStream(filePath, FileMode.Create);
                    FileUpload.CopyTo(fileStream);
                }

                foreach(var f in FileUploads) 
                {
                    var filePath = Path.Combine(_environment.WebRootPath, "uploads", f.FileName);
                    using var fileStream = new FileStream(filePath, FileMode.Create);
                    f.CopyTo(fileStream);  
                }
            }
            else {
                message = "The submit form was send is not Valid!";
            }
        }
    }
}
