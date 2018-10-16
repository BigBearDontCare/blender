using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.Security
{
  [Table("GroupModule", Schema = "security")]
  public class GroupModule
  {
    [Key]
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ModuleId { get; set; }

    [ForeignKey("GroupId")]
    public Group Group { get; set; }

    [ForeignKey("ModuleId")]
    public Module Module { get; set; }
  }
}
