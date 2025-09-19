using System;
using System.Text.Json.Serialization;
namespace SchedulerApp.Models
{
    public class WebAPIRecurring
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        public string? text { get; set; }
        public string? start_date { get; set; }
        public string? end_date { get; set; }
        public int? duration { get; set; }
        public string? rrule { get; set; }
        public string? recurring_event_id { get; set; }
        public string? original_start { get; set; }
        public bool? deleted { get; set; }

        public static explicit operator WebAPIRecurring(SchedulerRecurringEvent ev)
        {
            return new WebAPIRecurring
            {
                id = ev.Id,
                text = ev.Name,
                start_date = ev.StartDate.ToString("yyyy-MM-dd HH:mm"),
                end_date = ev.EndDate.ToString("yyyy-MM-dd HH:mm"),
                duration = ev.Duration,
                rrule = ev.Rrule,
                recurring_event_id = ev.RecurringEventId,
                original_start = ev.OriginalStart,
                deleted = ev.Deleted,
            };
        }

        public static explicit operator SchedulerRecurringEvent(WebAPIRecurring ev)
        {
            return new SchedulerRecurringEvent
            {
                Id = ev.id,
                Name = ev.text,
                StartDate = ev.start_date != null ? DateTime.Parse(ev.start_date,
                  System.Globalization.CultureInfo.InvariantCulture) : new DateTime(),
                EndDate = ev.end_date != null ? DateTime.Parse(ev.end_date,
                  System.Globalization.CultureInfo.InvariantCulture) : new DateTime(),
                Duration = ev.duration,
                Rrule = ev.rrule,
                RecurringEventId = ev.recurring_event_id,
                OriginalStart = ev.original_start,
                Deleted = ev.deleted
            };
        }
    }
}