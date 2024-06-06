using Hotel.Core.DTOs;
using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    public  class Mapping
    {
        public EmployeeDto EmployeeToEmployeeDto(Employee employee)
        {
            return new EmployeeDto { Id = employee.Id,Name = employee.Name,Age = employee.Age,Hours=employee.Hours};
        }

        public GuestDto GuestToGuestDto(Guest guest) 
        {
           return new GuestDto { Id = guest.Id,Count = guest.Count,Start=guest.Start,End=guest.End,RoomId=guest.RoomId};
        }

        public RoomDto RoomToRoomDto(Room room) 
        {
           return new RoomDto { Id = room.Id,Bades=room.Bades,Stastus=room.Stastus,EmployeeId=room.EmployeeId};
        }
    }
}
