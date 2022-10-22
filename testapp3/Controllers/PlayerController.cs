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
        private readonly IBidding bidding;
        public PlayerController(IPlayer player, IBidding bidding)
        {
            this.player = player;
            this.bidding = bidding;
        }

        [HttpGet("getSortedPlayerList")]
        public List<PlayerPayload> GetSortedPayload(int type)
        {
            return null;
        }

        [HttpGet("getAllPendingBiddings")]
        public List<BiddingResponse> GetAllPendingBiddings()
        {
            return bidding.GetAllPendingPayloads();
        }
    }
}
