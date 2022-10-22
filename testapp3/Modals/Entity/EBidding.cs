using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_BIDDING")]
    public class EBidding
    {
        [Key]
        public long id { get; set; }

        [Required]
        public EPlayerWithTrophy player { get; set; }

        [Required]
        public long lastBidderId { get; set; }

        [Required]
        public double startingPrice { get; set; }

        [Required]
        public double endPrice { get; set; }

        [Required]
        public string createdDate { get; set; }
        
        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int status { get; set; }


        public EBidding() { }

        public EBidding(long id, EPlayerWithTrophy player, long lastBidderId, double startingPrice, double endPrice, string createdDate, string lastUpdate, int status)
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

        public EBidding setBiddingDetails(EPlayerWithTrophy ePlayerWithTrophy,BiddingPayload biddingPayload)
        {
            EBidding eBidding = new EBidding();
            eBidding.id = biddingPayload.id;
            eBidding.player = ePlayerWithTrophy;
            eBidding.lastBidderId = biddingPayload.lastBidderId;
            eBidding.startingPrice = biddingPayload.startingPrice;
            eBidding.endPrice = biddingPayload.endPrice;
            eBidding.createdDate = biddingPayload.createdDate;
            eBidding.lastUpdate = biddingPayload.lastUpdate;
            eBidding.status = biddingPayload.status;
            return eBidding;
        }
    }
}
