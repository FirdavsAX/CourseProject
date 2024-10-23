namespace CourseProject.Models.Entities;

public class Form
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }

    // Foreign keys
    public int TemplateId { get; set; }
    public Template Template { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    // Navigation property
    public ICollection<Answer> Answers { get; set; }
}

