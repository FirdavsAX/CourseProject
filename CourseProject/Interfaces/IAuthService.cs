using CourseProject.Models.Entities;
using CourseProject.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CourseProject.Interfaces;

public interface IAuthService
{
    Task<string> RegisterAsync(RegisterViewModel register);
    Task<string> LoginAsync(LoginViewModel login);
    string GenerateBlockedToken(User user);
}
