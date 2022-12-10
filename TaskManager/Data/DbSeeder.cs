using Microsoft.EntityFrameworkCore;

namespace TaskManager.Data
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        { 
            List<Task> tasks = new List<Task>();
            {
                new Task() { Id = 1, Name = "Code", Deadline = DateTime.Now, Description = "Code web application", Priority = 1, Tags = "code, c#, asp, .net" };
                new Task() { Id = 2, Name = "Shopping", Deadline = DateTime.Now, Description = "Go shop", Priority = 2, Tags = "food, shop, shopping" };
            };
            modelBuilder.Entity<Task>().HasData(tasks);
        }
    }
}
