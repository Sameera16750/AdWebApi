using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class TeamImpl : ITeam
    {
        ITeamRepo teamRepo;
        IUserRepo userRepo;
        ETeam eTeam=new ETeam();
        TeamPayload teampayload=new TeamPayload();
        DefaultResponse response=new DefaultResponse();

        public TeamImpl(ITeamRepo teamRepo, IUserRepo userRepo)
        {
            this.teamRepo = teamRepo;
            this.userRepo = userRepo;
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

        public TeamPayload GetTeamByOwnerId(long id)
        {
            ETeamOwner eTeamOwner = teamRepo.GetOwnerById(id);
            if(eTeamOwner!= null)
            {
                return teampayload.setTeamPayloadDetails(eTeamOwner.team);
            }
            else
            {
                return null;
            }
        }

        public TeamPayload GetTeamByUserId(long id)
        {
            EUser selectedUser=userRepo.GetUserById(id);
            if(selectedUser!= null)
            {
                ETeamOwner teamOwner= teamRepo.GetOwnerByUser(selectedUser);
                if(teamOwner!= null)
                {
                    return teampayload.setTeamPayloadDetails(teamOwner.team);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
