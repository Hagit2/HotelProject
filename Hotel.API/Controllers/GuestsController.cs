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
    public class GuestsController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestsController(IGuestService guestService,IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }
    
        // GET: api/<GuestsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _guestService.GetAll();
            var listDto = _mapper.Map<IEnumerable<GuestDto>>(list);
            return Ok(listDto);
           
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var guest= _guestService.Get(id);
            var guestdto=_mapper.Map<GuestDto>(guest);
            return Ok(guestdto);
        }

        // POST api/<GuestsController>
        [HttpPost]
        public Guest Post([FromBody] GuestPostModel value)
        {
            var guestToAdd = new Guest { Count = value.Count, Start = value.Start, End = value.End,RoomId=value.RoomId };
            return _guestService.Add(guestToAdd);    
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public Guest Put(int id, [FromBody] GuestPostModel value)
        {
            var guestToAdd = new Guest { Count = value.Count, Start = value.Start, End = value.End, RoomId = value.RoomId };
            return _guestService.Update(guestToAdd, id);    
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _guestService.Delete(id);   
        }
    }
}
