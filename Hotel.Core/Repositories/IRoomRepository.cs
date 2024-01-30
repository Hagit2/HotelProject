using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Repositories
{
    public interface IRoomRepository
    {
        List<Room> GetAllRooms();
        Room GetRoomById(int id);
        void Delete(int id);
        Room Add(Room room);
        Room Update(int id, Room room);
    }
}
