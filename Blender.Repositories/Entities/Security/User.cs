using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blender.Repositories.Entities.List;

namespace Blender.Repositories.Entities.Security
{
  [Table("User")]
  public class User
  {
    [Key]
    public long Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NickName { get; set; }
    public string Phone { get; set; }
    [ForeignKey("Carrier")]
    public int CarrierId { get; set; }
    public bool AllowSMS { get; set; }
    public bool AllowEmail { get; set; }
    public bool IsActive { get; set; }

    public Carrier Carrier { get; set; }
  }
}
