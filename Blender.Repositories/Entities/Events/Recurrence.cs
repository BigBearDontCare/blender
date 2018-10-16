using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blender.Repositories.Entities.Events
{
  [Table("EventRecurrence", Schema = "events")]
  public class EventRecurrence : Event
  {
    public string Frequency { get; set; }
    public byte FrequencyInterval { get; set; }
    public string Recurrence { get; set; }
    public byte RecurrenceInterval { get; set; }
    public string RecurrenceUnit { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
  }
}
