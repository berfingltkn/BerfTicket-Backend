using Businnes.Abstract;
using Businnes.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;
        public TicketManager(ITicketDal ticketDal) {
        
            _ticketDal= ticketDal;
        }
        public IResult Add(Ticket ticket)
        {
            _ticketDal.Add(ticket);
            return new SuccessResult(Messages.TicketAdded);
        }

        public IResult Delete(Ticket ticket)
        {
            var deletedTicket = _ticketDal.Get(c => c.TicketID == ticket.TicketID);
            _ticketDal.Delete(deletedTicket);
            return new SuccessResult(Messages.TicketDeleted);
        }

        public IDataResult<List<Ticket>> GetAll()
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(),Messages.TicketsListed);
        }

        public IDataResult<Ticket> GetTicketById(int id)
        {
            return new SuccessDataResult<Ticket>(_ticketDal.Get(t => t.TicketID == id), Messages.TicketListed);
        }

        public IResult Update(Ticket ticket)
        {
            _ticketDal.Update(ticket);
            return new SuccessResult(Messages.TicketUpdated);
        }
    }
}
