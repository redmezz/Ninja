using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Ninja.Models;

namespace Ninja.Data
{
  public class ApplicationDbContext : DbContext
  {

        private readonly IHttpContextAccessor _httpContextAccessor;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
    {
            _httpContextAccessor = httpContextAccessor;
    }

    
    public DbSet<Forum> Forums { get; set; }
  }
}
