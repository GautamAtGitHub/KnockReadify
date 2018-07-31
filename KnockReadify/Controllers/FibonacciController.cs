using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KnockReadify.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]int n)
        {
            try
            {
                int a = 0;
                int b = 1;
                int temp = 0;
                // In N steps compute Fibonacci sequence iteratively.
                for (int i = 0; i < n; i++)
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
