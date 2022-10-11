using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testapp3.Payloads;
using testapp3.Services.InterFaces;

namespace testapp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrophyController : ControllerBase
    {
        private readonly ITrophy trophy;

        public TrophyController(ITrophy trophy)
        {
            this.trophy = trophy;
        }

        [HttpPost("addTrophy")]
        public DefaultResponse AddTrophy([FromBody]TrophyPayload trophyPayload)
        {
            return trophy.AddTrophy(trophyPayload);
        }
        
        [HttpPost("playerTrophyRequest")]
        public DefaultResponse playerRequestTrophy([FromBody]PlayerRequestTrophyPayload playerRequest)
        {
            return trophy.PlayerRequestTrophy(playerRequest);
        }
    }
}
