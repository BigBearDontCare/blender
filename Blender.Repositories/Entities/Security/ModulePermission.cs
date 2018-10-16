using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.Security
{
  [Table("ModulePermission", Schema = "security")]
  public class ModulePermission
  {
    [Key]
    [Column(Order = 0)]
    public int ModuleId { get; set; }

    [Key]
    [Column(Order = 1)]
    public int PermissionId { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    public bool IsActive { get; set; }
  }
}
