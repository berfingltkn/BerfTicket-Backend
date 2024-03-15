using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface ITicketService
    {
        IDataResult<Ticket> GetTicketById(int id);
        IDataResult<List<Ticket>> GetAll();
        IResult Add(Ticket ticket);
        IResult Update(Ticket ticket);
        IResult Delete(Ticket ticket);
    }
}
