using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.Security
{
  [Table("GroupModulePermission", Schema = "security")]
  public class GroupModulePermission
  {
    [Key]
    [Column(Order = 0)]
    public int GroupModuleId { get; set; }

    [Key]
    [Column(Order = 1)]
    public int PermissionId { get; set; }

    [ForeignKey("GroupModuleId")]
    public GroupModule GroupModule { get; set; }

    [ForeignKey("PermissionId")]
    public Permission Permission { get; set; }
  }
}
