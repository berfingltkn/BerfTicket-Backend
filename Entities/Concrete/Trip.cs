using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Trip : IEntity
    {
        public int TripID { get; set; }
        public int DepartureCityID { get; set; }//kalkış şehri
        public int ArrivalCityID { get; set; }//varış sehri
        public TimeSpan DepartureTime { get; set; }//kalkış saati
        public TimeSpan ArrivalTime { get; set; }//varış saati
        public DateTime DepartureDate { get; set; }//kalkış tarihi
        public int Price { get; set; }
        public int BusID { get; set; }
        

    }
}
