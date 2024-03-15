using Businnes.Abstract;
using Businnes.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
           _cityDal.Add(city);
            return new SuccessResult(Messages.CityAdded);
        }

        public IResult Delete(City city)
        {
            var deletedCity=_cityDal.Get(c=>c.CityID == city.CityID);
            _cityDal.Delete(deletedCity);
            return new SuccessResult(Messages.CityDeleted);
        }

        public IDataResult<List<City>> GetAll()
        {
           return new SuccessDataResult<List<City>>(_cityDal.GetAll(),Messages.CitiesListed);
        }

        public IDataResult<City> GetCityById(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c=>c.CityID==id),Messages.CityListed);
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.CityUpdated);
        }
    }
}
