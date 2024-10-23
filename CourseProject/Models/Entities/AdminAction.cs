namespace CourseProject.Models.Entities;

public class AdminAction
{
    public int Id { get; set; }
    public string Action { get; set; } // 'Block', 'Unblock', 'Delete', 'AddAdmin', etc.
    public DateTime ActionDate { get; set; }

    // Foreign keys
    public int AdminId { get; set; }
    public User Admin { get; set; }

    public int TargetUserId { get; set; }
    public User TargetUser { get; set; }
}
