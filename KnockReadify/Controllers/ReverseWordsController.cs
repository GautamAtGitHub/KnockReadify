using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                return Ok(String.Join(" ", sentence.Split(' ').Reverse()));
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }

        }
    }
}