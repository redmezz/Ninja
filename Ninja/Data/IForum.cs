using Ninja.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ninja.Data
{
    public interface IForum
    {
        Models.Forum GetById(int id);
        IEnumerable<Models.Forum> GetAll();
        Task Create(Models.Forum forum);
        Task Delete(int id);
        Task UpdateForumDescription(int id, string description);
        Task UdateForumTitle(int id, string title);
        ForumPost GetLatestPost(int forumId);
        bool HasRecentPost(int id);
        Task Add(Models.Forum forum);
    }
}
