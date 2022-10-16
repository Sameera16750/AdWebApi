using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using testapp3.Payloads;
using testapp3.Services.InterFaces;

namespace testapp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayer player;

        public PlayerController(IPlayer player)
        {
            this.player = player;
        }

        [HttpGet("getSortedPlayerList")]
        public List<PlayerPayload> GetSortedPayload(int type)
        {
            return null;
        }
    }
}
