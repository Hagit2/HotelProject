using Hotel.Core.Entities;
using Hotel.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories
{
    public class RoomRepository: IRoomRepository
    {
        private readonly DataContexst _context;
        public RoomRepository(DataContexst context)
        {
            _context = context;
        }

        public Room Add(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return room;    
        }

        public void Delete(int id)
        {
            var room = GetRoomById(id); 
            _context.Rooms.Remove(room);
            _context.SaveChanges();


        }

        public List<Room> GetAllRooms()
        {
          return  _context.Rooms.Include(r => r.Guest).ToList();//
        }

        public Room GetRoomById(int id)
        {
            return _context.Rooms.Find(id); //לבדוק אם התחביר נכון 
        }

        public Room Update(int id, Room room)
        {
             var _room=GetRoomById(id);
           // _room.Start = room.Start;
           // _room.End = room.End;   
            _room.Stastus = room.Stastus;   
            _room.Bades = room.Bades;
            _context.SaveChanges();
             return _room;   
        }
    }
}
