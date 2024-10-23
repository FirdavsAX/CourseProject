using System.ComponentModel.DataAnnotations;

namespace CourseProject.ViewModels.Template;

public class CreateQuestionViewModel
{
    [Required]
    public string QuestionText { get; set; }

    [Required]
    public string QuestionType { get; set; }  // 'Text', 'MultipleChoice', etc.

    public bool IsRequired { get; set; }

    public int TemplateId { get; set; }
}
