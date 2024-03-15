using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Bus:IEntity
    {
        public int BusID {  get; set; }
        public string Plate {  get; set; }
        public int Capacity {  get; set; }
        public string Brand { get; set; }

    }
}
