using Microsoft.EntityFrameworkCore;
using Ninja.Models;

namespace Ninja.Data
{
    public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    
    public DbSet<Forum> Forums { get; set; }
    public DbSet<SubForum> SubForums { get; set; }
    public DbSet<ForumPost> ForumPosts { get; set; }
  }
}
