using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blender.Repositories.Entities.Families;
using Blender.Repositories.Entities.Security;

namespace Blender.Repositories.Entities.Events
{
  [Table("Event", Schema = "events")]
  public class Event
  {
    [Key]
    public Guid Id { get; set; }
    public Guid FamilyId { get; set; }
    public long OwnerId { get; set; }

    public string Title { get; set; }
    public string Location { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
    public bool FullDay { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string Notes { get; set; }

    [ForeignKey("FamilyId")]
    public Family Family { get; set; }

    [ForeignKey("OwnerId")]
    public User Owner { get; set; }
  }
}
