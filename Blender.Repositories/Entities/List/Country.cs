using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.List
{
  [Table("Country", Schema = "list")]
  public class Country
  {
    [Key]
    public string CountryCode { get; set; }
    public string Name { get; set; }
    public string ISO2 { get; set; }
    public string ISO3 { get; set; }
    public bool IsActive { get; set; }
  }
}
