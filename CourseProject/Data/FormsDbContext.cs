using CourseProject.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Data;

public class FormsDbContext(DbContextOptions<FormsDbContext> context) : IdentityDbContext<User>(context)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Template> Templates { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Form> Forms { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<TemplateTag> TemplateTags { get; set; }
    public DbSet<AdminAction> AdminActions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Many-to-many relationship between Template and Tag
        modelBuilder.Entity<TemplateTag>()
            .HasKey(tt => new { tt.TemplateId, tt.TagId });

        modelBuilder.Entity<TemplateTag>()
            .HasOne(tt => tt.Template)
            .WithMany(t => t.TemplateTags)
            .HasForeignKey(tt => tt.TemplateId);

        modelBuilder.Entity<TemplateTag>()
            .HasOne(tt => tt.Tag)
            .WithMany(t => t.TemplateTags)
            .HasForeignKey(tt => tt.TagId);

        // Configure other relationships here if necessary
    }
}

