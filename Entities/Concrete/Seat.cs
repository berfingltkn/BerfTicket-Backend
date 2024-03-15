using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Seat : IEntity
    {
        public int SeatID {  get; set; }
        public int SeatNumber {  get; set; }
    }
}
