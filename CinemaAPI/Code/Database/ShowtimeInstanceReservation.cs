using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CinemaAPI.Code.Database
{
    public class ShowtimeInstanceReservation
    {
        public int Id { get; set; }
        public int ShowtimeInstanceId { get; set; }
        public int SeatNumber { get; set; }

        public ShowtimeInstance ShowtimeInstance { get; set; }
    }
}
