using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ticket : IEntity
    {
        public int TicketID { get; set; }
        public int TripID { get; set; }
        public int SeatID { get; set; }
        public int UserID { get; set; }
        public int BusID { get; set; }
    }
}
