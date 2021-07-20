using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ninja.Models
{
    public class Forum
  {
    [Key]
    public int Id { get; set; }

    [DisplayName("Forum Title")]
    public string ForumTitle { get; set; }
    public string Description { get; set; }
    public string ForumAuthor { get; set; }

    public ForumPost ForumPost { get; set; }

  }
}
