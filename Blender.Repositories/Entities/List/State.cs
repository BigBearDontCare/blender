using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.List
{
  [Table("State", Schema = "list")]
  public class State
  {
    [Key]
    [Column(Order = 0)]
    [StringLength(3)]
    public string CountryCode { get; set; }

    [Key]
    [Column(Order = 1)]
    [StringLength(3)]
    public string StateCode { get; set; }

    [StringLength(150)]
    public string Name { get; set; }

    public bool IsActive { get; set; }
  }
}
