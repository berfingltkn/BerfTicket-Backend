using Businnes.Abstract;
using Businnes.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class SeatManager : ISeatService
    {
        private readonly ISeatDal _seatDal;

        public SeatManager(ISeatDal seatDal)
        {
            _seatDal= seatDal;
        }
        public IResult Add(Seat seat)
        {
            _seatDal.Add(seat);
            return new SuccessResult(Messages.SeatAdded);
        }

        public IResult Delete(Seat seat)
        {
           var deletedSeat=_seatDal.Get(s=>s.SeatID == seat.SeatID);
            _seatDal.Delete(deletedSeat);
            return new SuccessResult(Messages.SeatDeleted);
        }

        public IDataResult<List<Seat>> GetAll()
        {
            return new SuccessDataResult<List<Seat>>(_seatDal.GetAll(),Messages.SeatsListed);
        }

        public IDataResult<Seat> GetSeatById(int id)
        {
            return new SuccessDataResult<Seat>(_seatDal.Get(s=>s.SeatID==id),Messages.SeatListed);
        }

        public IResult Update(Seat seat)
        {
            _seatDal.Update(seat);
            return new SuccessResult(Messages.SeatUpdated);
        }
    }
}
