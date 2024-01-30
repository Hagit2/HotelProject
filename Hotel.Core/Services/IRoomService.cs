using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Services
{
    public interface IRoomService
    {
        List<Room> GetAll();
        Room Get(int id);
        Room Add(Room room);
        Room Update(Room room, int id);
        void Delete(int id);
    }
}
