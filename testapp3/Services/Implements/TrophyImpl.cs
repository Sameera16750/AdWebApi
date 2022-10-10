using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class TrophyImpl : ITrophy
    {
        ITrophyRepo trophyRepo;
        ETrophy eTrophy=new ETrophy();
        DefaultResponse defaultResponse= new DefaultResponse();

        public TrophyImpl(ITrophyRepo trophyRepo)
        {
            this.trophyRepo = trophyRepo;
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
    }
}
