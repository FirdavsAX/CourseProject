﻿using System.ComponentModel.DataAnnotations;

namespace CourseProject.ViewModels.Authorization;
public class RegisterViewModel
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "User name is required")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Compare(nameof(Password), ErrorMessage = "Does not match password")]
    public string ConfirmPassword { get; set; }
}
