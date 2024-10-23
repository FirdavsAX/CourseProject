using CourseProject.ViewModels.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CourseProject.Models.Entities;

public class User : IdentityUser
{
    public Status Status { get; set; }
    public DateTime CreatedDate { get; set; }

    // Navigation properties
    public ICollection<Template> Templates { get; set; }
    public ICollection<Form> Forms { get; set; }
}
