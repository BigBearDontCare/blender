using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.List
{
  [Table("Carrier", Schema = "list")]
  public class Carrier
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Gateway { get; set; }
    public bool IsActive { get; set; }
  }
}
