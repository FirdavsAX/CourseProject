namespace CourseProject.Models.Entities;

public class Template
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; } 
    public string Topic { get; set; }
    public bool IsPublic { get; set; }
    public string ImageUrl { get; set; } 
    public DateTime CreatedDate { get; set; }

    public int AuthorId { get; set; }
    public User Author { get; set; }

    public ICollection<Question> Questions { get; set; }
    public ICollection<Form> Forms { get; set; }
}

