using CourseProject.Models.Entities;
using CourseProject.ViewModels.Authorization;
using CourseProject.ViewModels.Template;
using Microsoft.AspNetCore.Identity;

namespace CourseProject.Interfaces;

public interface ITemplateService
{
    Task CreateTemplateAsync(CreateTemplateViewModel model, string authorId);
    Task<List<CreateTemplateViewModel>> GetAllTemplatesAsync();
}
