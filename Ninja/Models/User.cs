using System;
using System.ComponentModel.DataAnnotations;

namespace Ninja.Models
{
  public class User
  {
    [Key]
    public int Id { get; set; }
    public bool IsAdmin { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Rank { get; set; }
    public string Section { get; set; }

    [DataType(DataType.EmailAddress)]
    public string EmailAddress { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    public DateTime Joined { get; set; }
  }

}