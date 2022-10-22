using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class BiddingPayload
    {
        public long id { get; set; }
        public PlayerRequestTrophyPayload player { get; set; }
        public long lastBidderId { get; set; }
        public double startingPrice { get; set; }
        public double endPrice { get; set; }
        public string createdDate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public BiddingPayload () { }
            
        public BiddingPayload(long id, PlayerRequestTrophyPayload player, long lastBidderId, double startingPrice, double endPrice, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.player = player;
            this.lastBidderId = lastBidderId;
            this.startingPrice = startingPrice;
            this.endPrice = endPrice;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public BiddingPayload setBiddingPAyload(PlayerRequestTrophyPayload playerRequestTrophy,EBidding eBidding)
        {
            BiddingPayload biddingPayload = new BiddingPayload();
            biddingPayload.id=eBidding.id;
            biddingPayload.player = playerRequestTrophy;
            biddingPayload.lastBidderId = eBidding.lastBidderId;
            biddingPayload.startingPrice=eBidding.startingPrice;
            biddingPayload.endPrice=eBidding.endPrice;
            biddingPayload.createdDate=eBidding.createdDate;
            biddingPayload.lastUpdate=eBidding.lastUpdate;
            biddingPayload.status=eBidding.status;
            return biddingPayload;
        }
    }
}
