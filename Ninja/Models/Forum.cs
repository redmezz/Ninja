using System;
using System.ComponentModel;

namespace Ninja.Models
{
  public class Forum
  {
    public int Id { get; set; }

    [DisplayName("Forum Title")]
    public string ForumTitle { get; set; }
    public string Description { get; set; }

  }
}
