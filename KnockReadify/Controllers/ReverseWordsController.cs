using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KnockReadify.Controllers
{
    [Produces("application/json")]
    [Route("api/ReverseWords")]
    public class ReverseWordsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]string sentence)
        {
            try
            {
                if (sentence != null)
                {
                    var result = await Task.Run(() => {
                        return string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())));
                    });

                    return Ok(result);
                }
                else return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }

        }
    }
}