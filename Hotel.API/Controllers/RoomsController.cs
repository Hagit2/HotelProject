using AutoMapper;
using Hotel.API.Models;
using Hotel.Core;
using Hotel.Core.DTOs;
using Hotel.Core.Entities;
using Hotel.Core.Services;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomsController (IRoomService roomService,IMapper mapper)
        {
          _roomService = roomService;
            _mapper = mapper; 
        }
        // GET: api/<RoomsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _roomService.GetAll();
            var listDto =_mapper.Map<IEnumerable<RoomDto>>(list);
           return Ok(listDto);
            
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var room= _roomService.Get(id);
            var roomdto=_mapper.Map<RoomDto>(room);
            return Ok(roomdto);
        }

        // POST api/<RoomsController>
        [HttpPost]
        public Room Post([FromBody] RoomPostModel value)
        {
            var roomToAdd = new Room { Bades=value.Bades,Stastus=value.Stastus,EmployeeId=value.EmployeeId };
            return _roomService.Add(roomToAdd);
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public Room Put(int id, [FromBody] RoomPostModel value)
        {
            var roomToAdd = new Room { Bades = value.Bades, Stastus = value.Stastus, EmployeeId = value.EmployeeId };

            return _roomService.Update(roomToAdd, id);   
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roomService.Delete(id);    
        }
    }
}
