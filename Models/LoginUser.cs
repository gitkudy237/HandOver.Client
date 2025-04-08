using System;
using System.ComponentModel.DataAnnotations;

namespace HandOver.Client.Models;

public class LoginUser
{
    [Required]
    public string? UserName { get; set; }
    [Required]
    public string? Password { get; set; }
}
