namespace CourseProject.Models.Entities;

public class Answer
{
    public int Id { get; set; }
    public string AnswerText { get; set; }

    // Foreign keys
    public int FormId { get; set; }
    public Form Form { get; set; }

    public int QuestionId { get; set; }
    public Question Question { get; set; }
}

