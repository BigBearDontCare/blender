using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blender.Common.Enumerations;

namespace Blender.Repositories.Entities.Events
{
  [Table("NotificationLog", Schema = "events")]
  public class NotificationLog
  {
    [Key]
    public int Id { get; set; }
    public NotificationType NotificationType { get; set; }
    public DateTime DateSent { get; set; }
    public DateTime? DateReceived { get; set; }
    public Guid FamilyId { get; set; }
    public long EventId { get; set; }
    public long UserId { get; set; }
  }
}