using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.Security
{
  [Table("Permission", Schema = "security")]
  public class Permission
  {
    [Key]
    public int Id { get; set; }

    public Guid PermissionGuid { get; set; }

    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    public bool IsActive { get; set; }
  }
}
