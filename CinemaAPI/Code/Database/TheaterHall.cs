using System.Reflection.Metadata;

namespace CinemaAPI.Code.Database
{
    public enum SeatFurmula
    {
        FirstType,
        SecondType
    }

    public class TheaterHall
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }

        public byte HallNumber{ get; set; }
        public SeatFurmula SeatFormula { get; set; }
        public byte NumberOfSeats { get; set; }

        public Theater Theater { get; set; }
    }
}
