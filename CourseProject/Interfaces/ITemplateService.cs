using CourseProject.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseProject.Interfaces;

public interface ITemplateService
{
    Task<List<Template>> GetAllTemplatesAsync();
    Task<Template> GetTemplateByIdAsync(int id);
    Task CreateTemplateAsync(Template template);
    Task AddQuestionAsync(Question question);
}
