using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.DTOs
{
    public class RoomDto
    {
        public int Id { get; set; }

        public int Bades { get; set; }

        public Boolean Stastus { get; set; }

        public int EmployeeId { get; set; }
    }
}
