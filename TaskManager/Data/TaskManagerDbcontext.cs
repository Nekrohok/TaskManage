using Microsoft.EntityFrameworkCore;
using TaskManager.Data;

public class TaskManagerDbcontext : DbContext
{
    public TaskManagerDbcontext(DbContextOptions<TaskManagerDbcontext> options) : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Seed();
    }
    public DbSet<Task> Tasks { get; set; }
}
