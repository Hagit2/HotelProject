using Hotel.Core.Entities;
using Hotel.Core.Repositories;
using Hotel.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService (IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;   
        }
        public List<Room> GetAll()
        {
            return _roomRepository.GetAllRooms();
        }
        public Room Get(int id)
        {
            return _roomRepository.GetRoomById(id);
        }
        public Room Add(Room room)
        {
            return _roomRepository.Add(room);   
        }
        public Room Update(Room room, int id)
        {
            return _roomRepository.Update(id, room);
        }
        public void Delete(int id)
        {
            _roomRepository.Delete(id);
        }
    }
}
