using Microsoft.EntityFrameworkCore;
using job_manager.Models;

namespace job_manager.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Job> Jobs { get; set; }
    public DbSet<Employer> Employers { get; set; }
}
