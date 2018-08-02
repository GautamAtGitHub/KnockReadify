using Microsoft.AspNetCore.Mvc;
using System;

namespace KnockReadify.Controllers
{
    [Produces("application/json")]
    [Route("api/TriangleType")]
    public class TriangleTypeController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]int a, int b, int c)
        {
            try
            {
                if ((a + b > c) && a + c > b && b + c > a) // valid triangle
                {
                    if ((a == b) & (b == c)) //Equilateral (a == b) & (b == c) therefore (c == a)
                        return Ok("Equilateral");
                    else if (a == b || b == c || c == a) // Isoceles //There are only two distinct values in the set, therefore two sides are equal and one is not
                        return Ok("Isoceles");
                    else return Ok("Scalene"); //Scalene //There are three distinct values in the set, therefore no sides are equal
                }
                else throw new Exception("Invalid triangle input");
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }
           
        }
    }
}