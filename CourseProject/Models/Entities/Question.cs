namespace CourseProject.Models.Entities;

public class Question
{
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public string QuestionType { get; set; } // e.g., 'Text', 'Number', 'MultipleChoice'
    public bool IsRequired { get; set; }
    public DateTime CreatedDate { get; set; }

    // Foreign key
    public int TemplateId { get; set; }
    public Template Template { get; set; }
}

