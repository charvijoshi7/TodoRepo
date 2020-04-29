using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace TodoApi.Models
{
    public class TodoContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

       public Microsoft.EntityFrameworkCore.DbSet<TodoItem> TodoItem { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=mydb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
 }
}