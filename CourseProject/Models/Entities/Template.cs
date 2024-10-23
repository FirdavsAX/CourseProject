namespace CourseProject.Models.Entities;

public class Template
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; } // Supports Markdown formatting
    public string Topic { get; set; } // e.g., "Education", "Quiz", "Other"
    public bool IsPublic { get; set; }
    public string ImageUrl { get; set; } // Optional image URL
    public DateTime CreatedDate { get; set; }

    // Foreign keys
    public int AuthorId { get; set; }
    public User Author { get; set; }

    // Navigation properties
    public ICollection<Question> Questions { get; set; }
    public ICollection<Form> Forms { get; set; }
    public ICollection<TemplateTag> TemplateTags { get; set; }
}

