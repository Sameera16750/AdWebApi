using System.Collections.Generic;
using testapp3.Modals;
using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class BiddingImpl : IBidding
    {
        IBiddingRepo biddingRepo;
        ITeamRepo teamRepo;
        IPlayerRepo playerRepo;
        ITrophyRepo trophyRepo;
        EBidding eBidding = new EBidding();
        EPlayerWithTrophy ePlayerWithTrophy = new EPlayerWithTrophy();
        BiddingPayload biddingPayload=new BiddingPayload();
        BiddingResponse biddingResponse=new BiddingResponse();
        PlayerPayload playerPayload=new PlayerPayload();
        UserPayload userPayload=new UserPayload();
        TrophyPayload TrophyPayload=new TrophyPayload();
        PlayerRequestTrophyPayload playerRequestTrophyPayload=new PlayerRequestTrophyPayload();
        PlayerWithTrophyResponse playerWithTrophyResponse=new PlayerWithTrophyResponse();
        DefaultResponse defaultResponse = new DefaultResponse();

        public BiddingImpl(IBiddingRepo biddingRepo,ITeamRepo teamRepo,IPlayerRepo playerRepo,ITrophyRepo trophyRepo)
        {
            this.biddingRepo = biddingRepo;
            this.teamRepo = teamRepo;
            this.playerRepo = playerRepo;
            this.trophyRepo = trophyRepo;
        }

        public List<BiddingResponse> GetAllPendingPayloads()
        {
            List<EBidding>selectedList=biddingRepo.getPendingBiddings();
            List<BiddingResponse>biddingPayloads=new List<BiddingResponse>();
            if (selectedList.Count > 0)
            {
                for(int i = 0; i < selectedList.Count; i++)
                {
                    biddingPayloads.Add(
                    biddingResponse.setDetails(playerWithTrophyResponse.setDetails(playerPayload.
                        setDetails(selectedList[i].player.player, userPayload.
                        setDetails(selectedList[i].player.player.user)),
                        TrophyPayload.SetTrophyPayloadDetails(selectedList[i].player.trophy),
                        selectedList[i].player), selectedList[i]));
                }
                return biddingPayloads;
            }
            else
            {
                return null;
            }
        }

        public DefaultResponse updateBiddingRecord(BiddingPayload bidding)
        {
            long savedId = biddingRepo.updateBiddingRecord(eBidding.setBiddingDetails(ePlayerWithTrophy.
                setPlayerWithTrophyDetails(bidding.player, playerRepo.GetPlayerById(bidding.player.playerId),
                trophyRepo.GetTrophyById(bidding.player.trophyId)), bidding));

            if (savedId !=0)
            {
                return defaultResponse.setResponse(savedId,"update suceess",true);
            }
            else
            {
                return defaultResponse.setResponse(0, "samothing went wrong", false);
            }

        }
    }
}
