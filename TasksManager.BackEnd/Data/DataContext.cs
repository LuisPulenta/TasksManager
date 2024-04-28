using Microsoft.EntityFrameworkCore;
using TasksManager.Shared.Entities;

namespace TasksManager.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<MyTask> MyTasks { get; set; }
    }
}