using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class ContactRequest : PageModel
{

    private readonly ILogger<ContactRequest> _logger;
    
    [BindProperty]
    public UserContact userContact {get;set;}
    

    public ContactRequest(ILogger<ContactRequest> logger)
    {
        _logger = logger;
        Console.WriteLine("Init contact ... ");
    }

    public void OnPost()
    {
        System.Console.WriteLine(this.userContact.Email);
    }
}