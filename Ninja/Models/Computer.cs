using System;
using System.ComponentModel.DataAnnotations;

namespace Ninja.Models
{
  // Computer Sub-Forum DB Table
  public class Computer
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public DateTime Creation { get; set; }
    [Required]
    public string Content { get; set; }
    public virtual User Author { get; set; }

  }
}
