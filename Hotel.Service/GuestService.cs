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
    public class GuestService: IGuestService
    {
        private readonly IGuestRepository _guestRepository;

        public GuestService (IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }   
        public List<Guest> GetAll()
        {
            return _guestRepository.GetAllGuests();
        }
        public Guest Get(int id)
        {
            return _guestRepository.GetGuestById(id);
        }
        public Guest Update(Guest guest,int id)
        {
            return _guestRepository.Update(id, guest);
        }
        public void Delete(int id) 
        {
            _guestRepository.Delete(id);   
        }
        public Guest Add(Guest guest)
        {
            return _guestRepository.Add(guest); 
        }
    }
}
