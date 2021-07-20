using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ninja.Models
{
    public class ForumPost
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Post Title")]
        public string PostTitle { get; set; }
        public string Author { get; set; }
        public int NinjaPoints { get; set; }
    }
}
