using System;
using System.Collections.Generic;
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
        ITeamRepo teamRepo;
        ETrophy eTrophy=new ETrophy();
        EPlayer ePlayer=new EPlayer();
        ETrophyWithTeam etrophyWithTeam=new ETrophyWithTeam();
        EPlayerWithTrophy ePlayerWithTrophy = new EPlayerWithTrophy();
        TrophyPayload tPayload = new TrophyPayload();
        TrophyWithTeamPayload trophyWithTeamPayload = new TrophyWithTeamPayload();
        TeamPayload teamPayload= new TeamPayload();
        TeamOwnerPayload teamOwner = new TeamOwnerPayload();
        UserPayload userPayload=new UserPayload();
        AppliedTeamDetailsForTrophiesPayload appliedTeamDetails= new AppliedTeamDetailsForTrophiesPayload();
        DefaultResponse defaultResponse= new DefaultResponse();

        public TrophyImpl(ITrophyRepo trophyRepo, IPlayerRepo playerRepo,ITeamRepo teamRepo)
        {
            this.trophyRepo = trophyRepo;
            this.playerRepo = playerRepo;
            this.teamRepo=teamRepo;
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

        public List<TrophyPayload> GetAllActiveTrophies()
        {
            List<ETrophy> trophylist= trophyRepo.GetAllActiveTrophyList();
            if(trophylist.Count > 0)
            {
                return tPayload.SetTrophyList(trophylist);
            }
            else
            {
                return null;
            }
        }

        public List<AppliedTeamDetailsForTrophiesPayload> GetAllAppliedTeamsWithTrophies()
        {
            List<ETrophyWithTeam>trophyWithTeams=trophyRepo.getAllActiveTrophiesWithTeams();
            List<AppliedTeamDetailsForTrophiesPayload>appliedTeams=new List<AppliedTeamDetailsForTrophiesPayload>();
            Console.Write(trophyWithTeams[0]);
            if(trophyWithTeams.Count > 0)
            {
                for(int i = 0; i < trophyWithTeams.Count; i++)
                {
                    ETeamOwner eTeamOwner = teamRepo.GetOwnerByTeam(trophyWithTeams[i].team);
                    AppliedTeamDetailsForTrophiesPayload applied= appliedTeamDetails.setDetails(teamPayload.setTeamPayloadDetails(trophyWithTeams[i].team),
                        teamOwner.setDetails(eTeamOwner, teamPayload.setTeamPayloadDetails(trophyWithTeams[i].team),
                        userPayload.setDetails(eTeamOwner.user)),
                        trophyWithTeamPayload.setDetails(trophyWithTeams[i]));
                    appliedTeams.Add(applied);
                }
                    
                return appliedTeams;
            }
            else
            {
                return null;

            }
        }

        public DefaultResponse OwnerRequestTrophy(TrophyWithTeamPayload trophyWithTeam)
        {

            long savedId = trophyRepo.AddTrophyWithTeam(etrophyWithTeam.setTrophyWithTeamDetails(trophyWithTeam,
                trophyRepo.GetTrophyById(trophyWithTeam.trophyId), teamRepo.GetTeamById(trophyWithTeam.teamId)));
            if(savedId > 0)
            {
                return defaultResponse.setResponse(savedId,"Applying success 🎉🎉🎉",true);
            }
            else
            {
                return defaultResponse.setResponse(0, "<Internal server Error >applying fail, Somthing went wrong please try again later", false);
            }
        }

        public DefaultResponse PlayerRequestTrophy(PlayerRequestTrophyPayload playerRequest)
        {

            long savedRequestId = trophyRepo.AddPlayerRequestTrophy(ePlayerWithTrophy.setPlayerWithTrophyDetails(playerRequest, playerRepo.
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

        public DefaultResponse UpdateOwnerRequestTrophy(TrophyWithTeamPayload trophyWithTeam)
        {
            long updatedId = trophyRepo.UpdateTrophyWithTeam(etrophyWithTeam.
                setTrophyWithTeamDetails(trophyWithTeam, trophyRepo.GetTrophyById(trophyWithTeam.trophyId),
                teamRepo.GetTeamById(trophyWithTeam.teamId)));
            if (updatedId > 0)
            {
                return defaultResponse.setResponse(updatedId, "Record Update Success ", true);
            }
            else
            {
                return defaultResponse.setResponse(updatedId, "<Record not updated >Somthing went wrong please try again later", false);
            }
        }
    }
}
