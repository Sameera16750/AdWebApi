using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

        [HttpGet("getAllActiveTrophies")]
        public List<TrophyPayload> GetAllActiveTrophies()
        {
            return trophy.GetAllActiveTrophies();
        }

        [HttpPost("playerTrophyRequest")]
        public DefaultResponse PlayerRequestTrophy([FromBody]PlayerRequestTrophyPayload playerRequest)
        {
            return trophy.PlayerRequestTrophy(playerRequest);
        }

        [HttpPost("teamOwnerTrophyRequest")]
        public DefaultResponse OwnerRequestTrophy([FromBody]TrophyWithTeamPayload trophyWithTeam)
        {
            return trophy.OwnerRequestTrophy(trophyWithTeam);
        }

        [HttpPost("updateOwnertrophyRequest")]
        public DefaultResponse UpdateOwnerRequestTrophy([FromBody]TrophyWithTeamPayload trophyWithTeam)
        {
            return trophy.UpdateOwnerRequestTrophy(trophyWithTeam);
        }
    }
}
