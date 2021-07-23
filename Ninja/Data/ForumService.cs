using Microsoft.EntityFrameworkCore;
using Ninja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninja.Data
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _db;
        private readonly IForumPost _postService;

        public ForumService(ApplicationDbContext db, IForumPost postService)
        {
            _db = db;
            _postService = postService;
        }

        public async Task Add(Forum forum)
        {
            _db.Add(forum);
            await _db.SaveChangesAsync();
        }

        public async Task Create(Forum forum)
        {
            _db.Add(forum);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var forum = GetById(id);
            _db.Remove(forum);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _db.Forums
                .Include(forum => forum.Posts);
        }

        public Forum GetById(int id)
        {
            var forum = _db.Forums
                .Where(f => f.Id == id)
                .Include(f => f.Posts)
                .ThenInclude(f => f.User)
                .Include(f => f.Posts)
                .ThenInclude(p => p.Forum)
                .FirstOrDefault();

            if(forum.Posts == null)
            {
                forum.Posts = new List<ForumPost>();
            }

            return forum;
        }

        public ForumPost GetLatestPost(int forumId)
        {
            var posts = GetById(forumId).Posts;

        }

        public bool HasRecentPost(int id)
        {
            const int hoursAgo = 24;
            var window = DateTime.Now.AddHours(-hoursAgo);
            return GetById(id).Posts.Any(posts => posts.Created >= window);
        }

        public Task UdateForumTitle(int id, string title)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumDescription(int id, string description)
        {
            throw new NotImplementedException();
        }
    }
}
