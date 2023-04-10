using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class Contact : PageModel
{
    private readonly ILogger<Contact> _logger;

    public string UserId {get;set;} 

    public Contact(ILogger<Contact> logger)
    {
        _logger = logger;
        Console.WriteLine("Init contact ... ");
    }

}