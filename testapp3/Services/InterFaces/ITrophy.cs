using testapp3.Payloads;

namespace testapp3.Services.InterFaces
{
    public interface ITrophy
    {
        public DefaultResponse AddTrophy(TrophyPayload trophyPayload);
        
        public DefaultResponse PlayerRequestTrophy(PlayerRequestTrophyPayload playerRequest);

        public DefaultResponse OwnerRequestTrophy(TrophyWithTeamPayload trophyWithTeam);

        public DefaultResponse UpdateOwnerRequestTrophy(TrophyWithTeamPayload trophyWithTeam);
    }
}
