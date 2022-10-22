using testapp3.Modals.Entity;
using testapp3.Payloads;

namespace testapp3.Modals
{
    public class PlayerWithTrophyResponse
    {
        public long id { get; set; }
        public PlayerPayload player{ get; set; }
        public TrophyPayload trophy{ get; set; }
        public string createdDate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public PlayerWithTrophyResponse() { }

        public PlayerWithTrophyResponse(long id, PlayerPayload player, TrophyPayload trophy, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.player = player;
            this.trophy = trophy;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public PlayerWithTrophyResponse setDetails(PlayerPayload playerPayload,TrophyPayload trophy,EPlayerWithTrophy eplayerWithTrophy)
        {
            PlayerWithTrophyResponse playerWithTrophyResponse = new PlayerWithTrophyResponse();
            playerWithTrophyResponse.id=eplayerWithTrophy.id;
            playerWithTrophyResponse.player=playerPayload;
            playerWithTrophyResponse.trophy=trophy;
            playerWithTrophyResponse.createdDate=eplayerWithTrophy.createdDate;
            playerWithTrophyResponse.lastUpdate=eplayerWithTrophy.lastUpdate;
            playerWithTrophyResponse.status=eplayerWithTrophy.status;
            return playerWithTrophyResponse;

        }
    }
}
