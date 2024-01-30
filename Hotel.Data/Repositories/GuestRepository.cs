using Hotel.Core.Entities;
using Hotel.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly DataContexst _context;
        public GuestRepository(DataContexst context)
        {
            _context = context;
        }
        public Guest Add(Guest guest)
        {
            _context.Guests.Add(guest);
            _context.SaveChanges();
            return guest;
        }

        public void Delete(int id)
        {
            var guest=GetGuestById(id); 
            _context.Guests.Remove(guest);
            _context.SaveChanges();

        }

        public List<Guest> GetAllGuests()
        {
           return _context.Guests.ToList();
        }

        public Guest GetGuestById(int id)
        {
           return _context.Guests.Find(id); //לבדוק אם התחביר נכון 
        }

        public Guest Update(int id, Guest guest)
        {
            var _guest=GetGuestById(id);
            _guest.Start = guest.Start;
            _guest.End = guest.End;
            _guest.Count = guest.Count;
            _context.SaveChanges();
            return _guest;
        }
    }
}
