using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IBusService
    {
        IDataResult<Bus> GetBusById(int id);
        IDataResult<List<Bus>> GetAll();
        IResult Add(Bus bus);
        IResult Update(Bus bus);
        IResult Delete(Bus bus);
    }
}
