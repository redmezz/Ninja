using Ninja.Models;
using System.Threading.Tasks;

namespace Ninja.Data
{
    public interface IPostReply
    {
        PostReply GetById(int id);
        Task Edit(int id, string message);
        Task Delete(int id);
    }
}
