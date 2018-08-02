using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace KnockReadify.Controllers
{
    [Produces("application/json")]
    [Route("api/ReverseWords")]
    public class ReverseWordsController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]string sentence)
        {
            try
            {
                if (sentence != null)
                {
                    var result = string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())));
                    return Ok(result);
                }
                else throw new Exception("Invalid Input string");
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }

        }
    }
}