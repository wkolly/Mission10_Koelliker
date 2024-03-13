using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Koelliker_Backend.Data;

namespace Mission10_Koelliker_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private BowlingRepository _bowlingRepository;

        public BowlerController(BowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Bowler>> GetWithTeams()
        {
            var bowlerData = _bowlingRepository.GetAllBowlersWithTeams();
            if (bowlerData == null || !bowlerData.Any())
            {
                return NotFound();
            }
            return Ok(bowlerData);
        }


    }
}
