using System.ComponentModel.DataAnnotations;

namespace CW14.Models;

public class Person
{
    [Required(ErrorMessage = "Please enter first name")]
    [StringLength(30)]
    [Display(Name = "Employee Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please enter last name")]
    [StringLength(30)]
    [Display(Name = "Employee Name")]
    public string LasatName { get; set; }

    [PhoneNumber (ErrorMessage ="Phone Number must be start with 09")]
    public string PhoneNumber { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
    public string ConfirmPassword { get; set; }

}

[AttributeUsage(AttributeTargets.Property)]
public class PhoneNumberAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.StartsWith("09");
        }
        return false;
    }
}
