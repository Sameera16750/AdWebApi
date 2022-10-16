using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testapp3.Payloads;
using testapp3.Services.InterFaces;

namespace testapp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeam team;

        public TeamController(ITeam team)
        {
            this.team = team;
        }

        [HttpGet("getTeamByOwnerId")]
        public TeamPayload GetTeamByOwnerId(long ownerId)
        {
            return team.GetTeamByOwnerId(ownerId);
        }

        [HttpGet("getTeamByUserId")]
        public TeamPayload GetTeamByUserId(long userId)
        {
            return team.GetTeamByUserId(userId);
        }
    }
}
