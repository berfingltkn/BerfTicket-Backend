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
    public class BusManager : IBusService
    {
        private readonly IBusDal _busDal;

        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }
        public IResult Add(Bus bus)
        {
           _busDal.Add(bus);
            return new SuccessResult(Messages.BusAdded);
        }

        public IResult Delete(Bus bus)
        {
            _busDal.Delete(bus);
            return new SuccessResult(Messages.BusDeleted);
        }

        public IDataResult<List<Bus>> GetAll()
        {
           return new SuccessDataResult<List<Bus>>(_busDal.GetAll(),Messages.BusesListed);
        }

        public IDataResult<Bus> GetBusById(int id)
        {
            return new SuccessDataResult<Bus>(_busDal.Get(b=>b.BusID==id),Messages.BusListed);
        }

        public IResult Update(Bus bus)
        {
            _busDal.Update(bus);
            return new SuccessResult(Messages.BusUpdated);
        }
    }
}
