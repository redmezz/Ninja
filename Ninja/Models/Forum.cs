using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ninja.Models
{
    public class Forum
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Forum Title")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public virtual IEnumerable<ForumPost> Posts { get; set; }
    }
}
