using System;
using System.ComponentModel.DataAnnotations;

namespace HandOver.Client.Models;

public class RegisterUser
{
    [Required][StringLength(50)]
    public string? FirstName { get; set; }

    [Required][StringLength(50)]
    public string? LastName { get; set; }
    public string? UserName { get; set; }
    public string? Location { get; set; }

    [Required][StringLength(50)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
        ErrorMessage = "Invalid email address.")]
    public string? Email { get; set; }
    public long PhoneNumber { get; set; }
    
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        ErrorMessage = "Password must be at least 8 characters long, and include one letter, one number, and one special character.")]
        [Required][StringLength(50)]
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
}
