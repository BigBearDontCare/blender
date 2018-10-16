using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.Security
{
  [Table("Module", Schema = "security")]
  public class Module
  {
    [Key]
    public int Id { get; set; }

    public Guid ModuleGuid { get; set; }

    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(255)]
    public string Path { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    public bool IsActive { get; set; }
  }
}
