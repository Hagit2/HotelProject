using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Entities
{
    public class Guest
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Room Room { get; set; }
       // public int RoomId { get; set; } //לבדוק אם אפשר להציג בשתי הצדדים וזה לא פוגע
    }
}
