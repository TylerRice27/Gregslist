using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gregslist.Models;
using Gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {

        private readonly CarsService _cs;

        public CarsController(CarsService cs)
        {
            _cs = cs;
        }




        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            try
            {
                List<Car> cars = _cs.Get();
                return Ok(cars);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

    }
}