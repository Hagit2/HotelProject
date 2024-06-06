namespace Hotel.API.Models
{
    public class GuestPostModel
    {
        public int Count { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int RoomId { get; set; }
    }
}
