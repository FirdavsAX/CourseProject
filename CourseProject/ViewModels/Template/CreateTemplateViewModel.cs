namespace CourseProject.ViewModels.Template;

public class CreateTemplateViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Topic { get; set; }
    public bool IsPublic { get; set; }
    public string ImageUrl { get; set; }
    public ICollection<QuestionViewModel> Questions { get; set; } = new List<QuestionViewModel>();
}
