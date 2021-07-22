using Ninja.Models;
using System.Collections.Generic;

namespace Ninja.Data
{
    public interface IUser
    {
        User GetById(int id);
        IEnumerable<User> GetAll();
    }
}
