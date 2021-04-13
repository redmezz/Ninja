using Microsoft.EntityFrameworkCore;
using Ninja.Models;

namespace Ninja.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Forum> Forums { get; set; }
    public DbSet<Computer> ComputerForum { get; set; }
  }
}
