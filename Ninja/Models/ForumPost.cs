using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ninja.Models
{
    public class ForumPost
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public virtual User User { get; set; }
        public virtual Forum Forum { get; set; }
        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}
