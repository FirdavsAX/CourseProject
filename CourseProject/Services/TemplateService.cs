using CourseProject.Data;
using CourseProject.Interfaces;
using CourseProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseProject.Services;

public class TemplateService : ITemplateService
{
    private readonly FormsDbContext _context;

    public TemplateService(FormsDbContext context)
    {
        _context = context;
    }

    public async Task<List<Template>> GetAllTemplatesAsync()
    {
        return await _context.Templates.Include(t => t.Author).ToListAsync();
    }

    public async Task<Template> GetTemplateByIdAsync(int id)
    {
        return await _context.Templates
            .Include(t => t.Questions)
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task CreateTemplateAsync(Template template)
    {
        _context.Templates.Add(template);
        await _context.SaveChangesAsync();
    }

    public async Task AddQuestionAsync(Question question)
    {
        _context.Questions.Add(question);
        await _context.SaveChangesAsync();
    }
}
