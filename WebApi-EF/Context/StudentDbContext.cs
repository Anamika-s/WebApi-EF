using Microsoft.EntityFrameworkCore;
using WebApi_Demo.Models;

namespace WebApi_EF.Context
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(
            options) { }

        public DbSet<Student> Students{ get; set; }
    }
}
