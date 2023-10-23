using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CinemaAPI.Code.Database
{
    public class ShowtimeInstance
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int HallId { get; set; }

        public TheaterHall Hall { get; set; }
    }
}
