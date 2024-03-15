using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatsController : ControllerBase
    {
        public readonly ISeatService _seatService;
        public SeatsController(ISeatService seatService)
        {
            _seatService = seatService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _seatService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Seat seat)
        {

            var result = _seatService.Add(seat);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Seat seat)
        {

            var result = _seatService.Update(seat);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int seatID)
        {

            var seat = new Seat { SeatID=seatID};
            var result = _seatService.Delete(seat);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getseatbyid")]
        public IActionResult GetSeatById(int id)
        {
            var result=_seatService.GetSeatById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
