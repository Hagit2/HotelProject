using AutoMapper;
using Hotel.Core.DTOs;
using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile() 
        {
            CreateMap<Employee,EmployeeDto>().ReverseMap();
            CreateMap<Guest, GuestDto>().ReverseMap();
            CreateMap<Room, RoomDto>().ReverseMap();
        } 
    }
}
