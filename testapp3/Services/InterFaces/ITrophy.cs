using System.Collections.Generic;
using testapp3.Payloads;

namespace testapp3.Services.InterFaces
{
    public interface ITrophy
    {
        public DefaultResponse AddTrophy(TrophyPayload trophyPayload);

        public List<TrophyPayload> GetAllActiveTrophies();
        
        public DefaultResponse PlayerRequestTrophy(PlayerRequestTrophyPayload playerRequest);

        public DefaultResponse OwnerRequestTrophy(TrophyWithTeamPayload trophyWithTeam);

        public DefaultResponse UpdateOwnerRequestTrophy(TrophyWithTeamPayload trophyWithTeam);
    }
}
