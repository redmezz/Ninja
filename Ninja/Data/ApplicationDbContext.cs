using Microsoft.AspNetCore.Identity;
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
        public DbSet<PostReply> PostReplies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
    }
}
