// AuthController.cs
using CourseProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using CourseProject.Interfaces;
using Microsoft.AspNetCore.Identity;
using CourseProject.Models.Entities;

namespace CourseProject.Controllers;

public class AuthController : Controller
{
    private readonly IAuthService _authService;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IConfiguration _configuration;

    public AuthController(IAuthService authService, 
        UserManager<User> user,
        SignInManager<User> signInManager,
        IConfiguration configuration)
    {
        _authService = authService;
        _userManager = user;
        _signInManager=signInManager;
        _configuration=configuration;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _authService.RegisterAsync(model);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(model);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginViewModel loginModel)
    {
        var token = await _authService.LoginAsync(loginModel);
        if (token != null)
        {
            return Ok(new { token, expiration = DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpiryInMinutes"])) });
        }

        return Unauthorized();
    }
}
