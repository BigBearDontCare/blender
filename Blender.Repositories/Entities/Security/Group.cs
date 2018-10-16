using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.Security
{
  [Table("Group", Schema = "security")]
  public class Group
  {
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    public bool IsActive { get; set; }
  }
}
