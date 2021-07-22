using Ninja.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ninja.Data
{
    public interface IForumPost
    {
        Task Add(ForumPost post);
        Task Delete(int id);
        Task EditPostContent(int id, string content);
        Task AddReply(PostReply reply);
        int GetReplyCount(int id);

        ForumPost GetById(int id);
        IEnumerable<ForumPost> GetAll();
        IEnumerable<ForumPost> GetPostsByUserId(int id);
        IEnumerable<ForumPost> GetPostsByForumId(int id);
        IEnumerable<ForumPost> GetLatestPosts(int forumId);
    }
}
