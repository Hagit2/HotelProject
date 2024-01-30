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
        
        public GuestsController(IGuestService guestService)
        {
            _guestService = guestService;
        }
    
        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<Guest> Get()
        {
            return _guestService.GetAll();
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public Guest Get(int id)
        {
            return _guestService.Get(id);
        }

        // POST api/<GuestsController>
        [HttpPost]
        public Guest Post([FromBody] Guest value)
        {
            return _guestService.Add(value);    
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public Guest Put(int id, [FromBody] Guest value)
        {
           return  _guestService.Update(value, id);    
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _guestService.Delete(id);   
        }
    }
}
