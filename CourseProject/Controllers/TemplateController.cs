using CourseProject.Interfaces;
using CourseProject.Models.Entities;
using CourseProject.ViewModels.Template;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers;

public class TemplateController : Controller
{
    private readonly ITemplateService _templateService;
    private readonly UserManager<User> _userManager;

    public TemplateController(ITemplateService templateService, UserManager<User> userManager)
    {
        _templateService = templateService;
        _userManager = userManager;
    }

    // Display form to create new template
    [HttpGet]
    public IActionResult Create()
    {
        return View(new CreateTemplateViewModel());
    }

    // Handle form submission for creating a new template
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTemplateViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.GetUserAsync(User);
            await _templateService.CreateTemplateAsync(model, user.Id);
            return RedirectToAction("Index", "Template");
        }
        return View(model);
    }

    // Display all templates
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var templates = await _templateService.GetAllTemplatesAsync();
        return View(templates);
    }
}
