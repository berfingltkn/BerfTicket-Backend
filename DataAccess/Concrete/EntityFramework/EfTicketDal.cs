using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTicketDal:EfEntityRepositoryBase<Ticket,BusBookingDbContext>,ITicketDal
    {
        //Entity Framework deki işlemler EfEntityRepository dekiler olucak, exstra methodlar eklemek istersek Abstract folder ına interfacelere ekleyebiliriz ve bu sınıflarda EF işlemlerini yazabiliriz.
    }
}
