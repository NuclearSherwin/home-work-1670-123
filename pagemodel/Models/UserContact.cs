using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class UserContact {
    [BindProperty(SupportsGet = true)]
    [DisplayName("Enter ID")]
    [Range(1, 1000, ErrorMessage = "Wrong input")]
    public int UserId {get;set;}
    [BindProperty(SupportsGet = true)]
    [EmailAddress]
    [DisplayName("Enter email")]
    public string Email {get;set;}
    [BindProperty(SupportsGet = true)]
    [DisplayName("Enter Username")]
    public string UserName { get; set; }
}