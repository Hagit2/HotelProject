using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Entities
{
    public class Room
    {
        public int Id { get; set; }

        public int Bades { get; set; }

        public Boolean Stastus { get; set; }

      //  public DateTime Start { get; set; }

      //  public DateTime End { get; set; }

        public List <Guest> Guests { get; set; }
      //  public int GuestId { get; set; }//בגלל שאני רוצה להציג את זה בצד של האורחים    
    
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; } 
    }

}
