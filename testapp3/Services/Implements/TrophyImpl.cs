using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class TrophyImpl : ITrophy
    {
        ITrophyRepo trophyRepo;
        IPlayerRepo playerRepo;
        ETrophy eTrophy=new ETrophy();
        EPlayer ePlayer=new EPlayer();
        EPlayerWithTrophy ePlayerWithTrophy = new EPlayerWithTrophy();
        DefaultResponse defaultResponse= new DefaultResponse();

        public TrophyImpl(ITrophyRepo trophyRepo, IPlayerRepo playerRepo)
        {
            this.trophyRepo = trophyRepo;
            this.playerRepo = playerRepo;
        }

        public DefaultResponse AddTrophy(TrophyPayload trophyPayload)
        {
            long savedTrophyId = trophyRepo.AddTrophy(eTrophy.SetTrophyDetails(trophyPayload));
            if(savedTrophyId > 0)
            {
                return defaultResponse.setResponse(savedTrophyId, "Trophy saved success 🎉🎉🎉", true);
            }
            else
            {
                return defaultResponse.setResponse(0, "<Internal server error> Trophy not saved, Somthing Went wrong, try again later",false);
            }
        }

        public DefaultResponse PlayerRequestTrophy(PlayerRequestTrophyPayload playerRequest)
        {

            long savedRequestId = trophyRepo.PlayerRequestTrophy(ePlayerWithTrophy.setPlayerWithTrophyDetails(playerRequest, playerRepo.
                GetPlayerById(playerRequest.playerId), trophyRepo.GetTrophyById(playerRequest.trophyId)));
            if(savedRequestId > 0)
            {
                return defaultResponse.setResponse(savedRequestId, "Applying success 🎉🎉🎉", true);
            }
            else
            {
                return defaultResponse.setResponse(0, "<Internal server Error >applying fail, Somthing went wrong please try again later",false);
            }
        }
    }
}
