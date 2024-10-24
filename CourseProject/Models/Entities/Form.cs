namespace CourseProject.Models.Entities;

public class Form
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public int TemplateId { get; set; }
    public Template Template { get; set; }

    public int AuthorId { get; set; }
    public User Author { get; set; }

    public ICollection<Answer> Answers { get; set; }
}