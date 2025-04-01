using Microsoft.EntityFrameworkCore;
using WebApplication1_Angular_HttpCLient.Models;

namespace WebApplication1_Angular_HttpCLient.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
    }
}
