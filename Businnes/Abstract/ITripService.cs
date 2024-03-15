using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface ITripService
    {
        IDataResult<Trip> GetTripById(int id);
        IDataResult<List<Trip>> GetAll();
        IResult Add(Trip trip);
        IResult Update(Trip trip);
        IResult Delete(Trip trip);

        //kalkış ve gidiş şehrine göre seyahatleri listele
        IDataResult<List<Trip>> GetTripsByCityID(int departureCityID, int arrivalCityID);

        // kalkış-gidiş şehrine göre ve gidiş saatine göre seyahatleri listele
        IDataResult<List<Trip>> GetTripsByCityIDAndDate(int departureCityID, int arrivalCityID,DateTime departureDate);
    }
}
