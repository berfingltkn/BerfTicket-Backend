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
    public class TripManager : ITripService
    {
        private readonly ITripDal _tripDal;

        public TripManager(ITripDal tripDal)
        {
            _tripDal=tripDal;
        }
        public IResult Add(Trip trip)
        {
            _tripDal.Add(trip);
            return new SuccessResult(Messages.TripAdded);
        }

        public IResult Delete(Trip trip)
        {
            var deletedTrip = _tripDal.Get(c => c.TripID == trip.TripID);
            _tripDal.Delete(deletedTrip);
            return new SuccessResult(Messages.TicketDeleted);
        }

        public IDataResult<List<Trip>> GetAll()
        {
            return new SuccessDataResult<List<Trip>>(_tripDal.GetAll(), Messages.TripsListed);
        }

        public IDataResult<Trip> GetTripById(int id)
        {
            return new SuccessDataResult<Trip>(_tripDal.Get(t => t.TripID == id), Messages.TripListed);
        }

        public IDataResult<List<Trip>> GetTripsByCityID(int departureCityID, int arrivalCityID)
        {
            var trips = _tripDal.GetAll(t=>t.DepartureCityID==departureCityID
            && t.ArrivalCityID==arrivalCityID
            );
            return new SuccessDataResult<List<Trip>>(trips,Messages.TripsListed);
        }

        public IDataResult<List<Trip>> GetTripsByCityIDAndDate(int departureCityID, int arrivalCityID, DateTime departureDate)
        {
            var trips = _tripDal.GetAll(
                t=>t.DepartureCityID==departureCityID
                && t.ArrivalCityID==arrivalCityID
                && t.DepartureDate==departureDate.Date
                );
            return new SuccessDataResult<List<Trip>>(trips, Messages.TripsListed);
        }

        public IResult Update(Trip trip)
        {
            _tripDal.Update(trip);
            return new SuccessResult(Messages.TripUpdated);
        }
    }
}
