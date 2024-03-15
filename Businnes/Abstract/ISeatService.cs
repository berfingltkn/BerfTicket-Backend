using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface ISeatService
    {

        IDataResult<Seat> GetSeatById(int id);
        IDataResult<List<Seat>> GetAll();
        IResult Add(Seat seat);
        IResult Update(Seat seat);
        IResult Delete(Seat seat);

    }
}
