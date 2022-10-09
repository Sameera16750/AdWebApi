using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class TeamImpl : ITeam
    {
        ITeamRepo teamRepo;
        ETeam eTeam=new ETeam();
        DefaultResponse response=new DefaultResponse();

        public TeamImpl(ITeamRepo teamRepo)
        {
            this.teamRepo = teamRepo;
        }

        public DefaultResponse AddTeam(TeamPayload team)
        {
            long savedId=teamRepo.AddTeam(eTeam.setTeamDetails(team));
            if (savedId > 0)
            {
                return response.setResponse(savedId, "Team saved success 🎉🎉🎉", true);
            }
            else
            {
                return response.setResponse(savedId, "<Internal Server Error> somthing went wrong, team was not saved ", false);
            }
        }
    }
}
