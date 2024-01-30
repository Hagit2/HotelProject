using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Services
{
    public interface IGuestService
    {

        List<Guest> GetAll();
        Guest Get(int id);
        Guest Update(Guest guest, int id);
        void Delete(int id);
        Guest Add(Guest guest);
    }
}
