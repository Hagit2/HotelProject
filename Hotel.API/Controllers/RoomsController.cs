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
        public RoomsController (IRoomService roomService)
        {
          _roomService = roomService;
        }
        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return _roomService.GetAll();
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public Room Get(int id)
        {
            return _roomService.Get(id);
        }

        // POST api/<RoomsController>
        [HttpPost]
        public Room Post([FromBody] Room value)
        {
            return _roomService.Add(value);
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public Room Put(int id, [FromBody] Room value)
        {
            return _roomService.Update(value,id);   
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roomService.Delete(id);    
        }
    }
}
