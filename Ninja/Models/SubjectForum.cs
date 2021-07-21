using System.ComponentModel;

namespace Ninja.Models
{
    public class SubjectForum
    {
        public int Id { get; set; }
        [DisplayName("Forum Title")]
        public string ForumTitle { get; set; }
        public string Description { get; set; }
        public string ForumAuthor { get; set; }
        public ForumPost ForumPost { get; set; }
    }
}
