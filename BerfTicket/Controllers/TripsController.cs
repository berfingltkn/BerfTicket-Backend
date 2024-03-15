using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        ITripService _tripService;

        public TripsController(ITripService tripService)
        {
            _tripService = tripService;
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _tripService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Trip trip)
        {

            var result = _tripService.Add(trip);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Trip trip)
        {

            var result = _tripService.Update(trip);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int tripID)
        {

            var trip = new Trip { TripID = tripID };
            var result = _tripService.Delete(trip);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("gettripbyid")]
        public IActionResult GetTripById(int id)
        {
            var result = _tripService.GetTripById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetTripsByCityIDAndDate")]
        public IActionResult GetTripsByCityIDAndDate(int departureCityID, int arrivalCityID, DateTime departureDate)
        {
            var result = _tripService.GetTripsByCityIDAndDate(departureCityID, arrivalCityID, departureDate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetTripsByCityID")]
        public IActionResult GetTripsByCityID(int departureCityID, int arrivalCityID)
        {
            //https://localhost:7224/api/trips/GetTripsByCityID?departureCityID=1&arrivalCityID=2

            var result = _tripService.GetTripsByCityID(departureCityID, arrivalCityID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
