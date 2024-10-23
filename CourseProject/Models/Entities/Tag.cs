namespace CourseProject.Models.Entities;

public class Tag
{
    public int Id { get; set; }
    public string TagName { get; set; }

    // Navigation properties
    public ICollection<TemplateTag> TemplateTags { get; set; }
}
