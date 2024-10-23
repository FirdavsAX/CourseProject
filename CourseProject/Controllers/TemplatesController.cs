using CourseProject.Interfaces;
using CourseProject.Models.Entities;
using CourseProject.ViewModels.Template;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers;

public class TemplateController : Controller
{
    private readonly ITemplateService _templateService;

    public TemplateController(ITemplateService templateService)
    {
        _templateService = templateService;
    }

    // GET: Template/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // POST: Template/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTemplateViewModel model)
    {
        if (ModelState.IsValid)
        {
            var template = new Template
            {
                Title = model.Title,
                Description = model.Description,
                Topic = model.Topic,
                IsPublic = model.IsPublic,
                ImageUrl = model.ImageUrl,
                CreatedDate = DateTime.Now,
                AuthorId = model.AuthorId  // Assuming this is set based on the logged-in user
            };

            await _templateService.CreateTemplateAsync(template);
            return RedirectToAction("Details", new { id = template.Id });
        }

        return View(model);
    }

    // GET: Template/Details/5
    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var template = await _templateService.GetTemplateByIdAsync(id);
        if (template == null)
        {
            return NotFound();
        }

        return View(template);
    }

    // GET: Template/AddQuestion/5
    [HttpGet]
    public IActionResult AddQuestion(int templateId)
    {
        var model = new CreateQuestionViewModel
        {
            TemplateId = templateId
        };
        return View(model);
    }

    // POST: Template/AddQuestion/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddQuestion(CreateQuestionViewModel model)
    {
        if (ModelState.IsValid)
        {
            var question = new Question
            {
                QuestionText = model.QuestionText,
                QuestionType = model.QuestionType,
                IsRequired = model.IsRequired,
                CreatedDate = DateTime.Now,
                TemplateId = model.TemplateId
            };

            await _templateService.AddQuestionAsync(question);
            return RedirectToAction("Details", new { id = model.TemplateId });
        }

        return View(model);
    }
}
