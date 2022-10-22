using testapp3.Modals;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class BiddingResponse
    {
        public long id { get; set; }
        public PlayerWithTrophyResponse playerWithTrophy { get; set; }
        public long teamOwner { get; set; }
        public double startingPrice { get; set; }
        public double endPrice { get; set; }
        public string createdDate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public BiddingResponse() { }

        public BiddingResponse(long id, PlayerWithTrophyResponse playerWithTrophy, long teamOwner, double startingPrice, double endPrice, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.playerWithTrophy = playerWithTrophy;
            this.teamOwner= teamOwner;
            this.startingPrice = startingPrice;
            this.endPrice = endPrice;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public BiddingResponse setDetails(PlayerWithTrophyResponse playerWithTrophyResponse,EBidding eBidding)
        {
            BiddingResponse biddingResponse = new BiddingResponse();
            biddingResponse.id = eBidding.id;
            biddingResponse.playerWithTrophy = playerWithTrophyResponse;
            biddingResponse.teamOwner = eBidding.lastBidderId;
            biddingResponse.startingPrice = eBidding.startingPrice;
            biddingResponse.endPrice = eBidding.endPrice;
            biddingResponse.createdDate = eBidding.createdDate;
            biddingResponse.lastUpdate = eBidding.lastUpdate;
            biddingResponse.status = eBidding.status;
            return biddingResponse;

        }
    }
}
