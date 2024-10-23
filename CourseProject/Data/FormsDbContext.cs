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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

