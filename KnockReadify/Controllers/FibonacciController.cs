using Microsoft.AspNetCore.Mvc;
using System;

namespace KnockReadify.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]Int64 n)
        {
            try
            {
                if (n < 0)
                    throw new Exception("Enter positive value");
                Int64 a = 0;
                Int64 b = 1;
                Int64 temp = 0;
                // In N steps compute Fibonacci sequence iteratively.
                for (Int64 i = 0; i < n; i++)
                {
                    temp = a;
                    a = b;
                    b = temp + b;
                }
                return Ok(a.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }
        }
    }
}
