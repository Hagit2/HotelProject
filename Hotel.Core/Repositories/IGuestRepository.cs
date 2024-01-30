using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Repositories
{
    public interface IGuestRepository
    {
        List<Guest> GetAllGuests();
        Guest GetGuestById(int id);
        void Delete(int id);
        Guest Add(Guest guest);
        Guest Update(int id, Guest guest);
    }
}
