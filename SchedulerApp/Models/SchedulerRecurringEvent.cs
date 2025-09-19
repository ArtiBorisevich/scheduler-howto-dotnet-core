using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchedulerApp.Models
{
    public class SchedulerRecurringEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Duration { get; set; }
        public string? Rrule { get; set; }
        public string? RecurringEventId { get; set; }
        public string? OriginalStart { get; set; }
        public bool? Deleted { get; set; }
    }
}
