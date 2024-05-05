using Microsoft.EntityFrameworkCore;

namespace _5D_Task.Models
{
    public class ApplicationDbContext:DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        { 
        }


        public DbSet<Client> Clients { get; set; }
    }
}
