using System.ComponentModel.DataAnnotations;

namespace CourseProject.ViewModels.Template;

public class CreateTemplateViewModel
{
    [Required]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string Description { get; set; }

    [StringLength(50, ErrorMessage = "Topic cannot exceed 50 characters.")]
    public string Topic { get; set; }

    public bool IsPublic { get; set; }

    public string ImageUrl { get; set; } // URL to an image

    public int AuthorId { get; set; } // The author's ID
}
