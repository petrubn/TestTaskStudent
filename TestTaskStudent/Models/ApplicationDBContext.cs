using Microsoft.EntityFrameworkCore;

namespace TestTaskStudent.Models;

public class ApplicationDBContext : DbContext    
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
    public DbSet<Student> Students { get; set; }
}