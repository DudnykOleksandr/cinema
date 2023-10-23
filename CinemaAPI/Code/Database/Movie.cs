using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CinemaAPI.Code.Database
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public ShowtimeSettings ShowtimeSettings { get; set; }
    }

    [Owned]
    public class ShowtimeSettings
    {
        public DateTime RepeatFromDate { get; set; }
        public DateTime RepeatToDate { get; set; }

        public List<ShowtimeReferenceInstance> ShowtimeDayReferenceInstances { get; set; }
    }

    [Owned]
    public class ShowtimeReferenceInstance
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int HallId { get; set; }

        public TheaterHall Hall { get; set; }
    }
}
