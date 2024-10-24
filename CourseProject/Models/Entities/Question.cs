namespace CourseProject.Models.Entities;

public class Question
{
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public string QuestionType { get; set; } 
    public bool IsRequired { get; set; }
    public DateTime CreatedDate { get; set; }

    public int TemplateId { get; set; }
    public Template Template { get; set; }
}
