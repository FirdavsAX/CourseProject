using CourseProject.Data;
using CourseProject.Interfaces;
using CourseProject.Models.Entities;
using CourseProject.ViewModels;
using CourseProject.ViewModels.Template;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly FormsDbContext _context;

        public TemplateService(FormsDbContext context)
        {
            _context = context;
        }

        public async Task CreateTemplateAsync(CreateTemplateViewModel model, string authorId)
        {
            var template = new Template
            {
                Title = model.Title,
                Description = model.Description,
                Topic = model.Topic,
                IsPublic = model.IsPublic,
                ImageUrl = model.ImageUrl,
                AuthorId = authorId,
                Created = DateTime.UtcNow,
                Questions = model.Questions.Select(q => new Question
                {
                    QuestionText = q.QuestionText,
                    QuestionType = q.QuestionType,
                    IsRequired = q.IsRequired,
                    CreatedDate = DateTime.UtcNow
                }).ToList()
            };

            _context.Templates.Add(template);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CreateTemplateViewModel>> GetAllTemplatesAsync()
        {
            return await _context.Templates
                .Select(t => new CreateTemplateViewModel
                {
                    Title = t.Title,
                    Description = t.Description,
                    Topic = t.Topic,
                    IsPublic = t.IsPublic,
                    ImageUrl = t.ImageUrl,
                    Questions = t.Questions.Select(q => new QuestionViewModel
                    {
                        QuestionText = q.QuestionText,
                        QuestionType = q.QuestionType,
                        IsRequired = q.IsRequired
                    }).ToList()
                })
                .ToListAsync();
        }
    }
}
