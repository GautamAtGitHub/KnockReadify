using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace KnockReadify.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]Int64 n)
        {
            try
            {
                var result = await Task.Run(() =>
                            {
                                if (n < -92 || n > 92)
                                    throw new Exception("Invalid Input");
                                bool IsConvert = false;
                                if (n < 0)
                                {
                                    IsConvert = true;
                                    n = System.Math.Abs(n);
                                }
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

                                if (IsConvert) a = (a * -1);
                                return a;
                            });

                return Ok(result.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }
        }
    }
}
