using System.Reflection.Metadata;

namespace CinemaAPI.Code.Database
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatBookingTimeoutInMinutes { get; set; }
        public List<TheaterHall> Halls { get; set; } 
    }
}
