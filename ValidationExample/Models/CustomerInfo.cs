using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using ValidationExample.Binders.UserNameBinding;

public class CustomerInfo {

    [Display(Name = "Customer Name")]
    [Required(ErrorMessage = "User not null")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} Error")]
    [ModelBinder(BinderType = typeof(UserNameBinding))]
    public string CustomerName {get;set;}

    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    
    [Display(Name = "Birth Day")]
    [Range(1970, 2023, ErrorMessage = "The year is out of range")]
    [TheEven]
    public int? YearOfBirth { get; set; }
}