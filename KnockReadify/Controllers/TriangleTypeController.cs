using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace KnockReadify.Controllers
{
    [Produces("application/json")]
    [Route("api/TriangleType")]
    public class TriangleTypeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]int a, int b, int c)
        {
            try
            {
                var result = await Task.Run(() =>
                {
                    if ((a + b > c) && a + c > b && b + c > a) // valid triangle
                    {
                        if ((a == b) & (b == c)) //Equilateral (a == b) & (b == c) therefore (c == a)
                            return Ok("Equilateral");
                        else if (a == b || b == c || c == a) // Isoceles //There are only two distinct values in the set, therefore two sides are equal and one is not
                            return Ok("Isosceles");
                        else return Ok("Scalene"); //Scalene //There are three distinct values in the set, therefore no sides are equal
                    }
                    else return Ok("Error");
                });
                return result;
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }

        }
    }
}