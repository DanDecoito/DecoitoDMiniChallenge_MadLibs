// Daniel Decoito
// 10-28-22
// Mini Challenge: MadLibs
// Recreate the madlibs minichallenge within the api thing
// reviewed by: Caroline Hana- The code was all right and made sense, was also neat and all done correctly. The madlib was creative and funny, nice job!



using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_MadLibs.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibsController : ControllerBase
{
   [HttpGet]
   [Route("Game/{name}/{game}/{adverb}/{dayOfWeek}/{location}")]
   public string Game(string name, string game, string adverb, string dayOfWeek, string location)
   {// there is five things




    return $"One day {name} was playing {game} with his brother. They both failed to realize that it was {dayOfWeek} so they {adverb} drove to {location}.";

   }
}
