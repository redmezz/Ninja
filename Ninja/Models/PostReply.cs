using System;

namespace Ninja.Models
{
    public class PostReply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public virtual User User { get; set; }
        public virtual ForumPost Post { get; set; }
    }
}
