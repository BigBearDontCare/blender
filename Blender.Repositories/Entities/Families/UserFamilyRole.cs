using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blender.Repositories.Entities.Security;

namespace Blender.Repositories.Entities.Families
{
  [Table("UserFamilyRole", Schema = "families")]
  public class UserFamilyRole
  {
    [Key]
    [Column(Order = 0)]
    public long UserId { get; set; }

    [Key]
    [Column(Order = 1)]
    public Guid FamilyId { get; set; }

    [Key]
    [Column(Order = 2)]
    public int RoleId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }

    [ForeignKey("FamilyId")]
    public Family Family { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; }
  }
}
