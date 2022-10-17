using System.Collections.Generic;

namespace testapp3.Payloads
{
    public class AppliedTeamDetailsForTrophiesPayload
    {
        public TeamPayload team { get; set; }
        public TeamOwnerPayload teamOwner { get; set; }
        public TrophyWithTeamPayload trophyWithTeam { get; set; }

        public AppliedTeamDetailsForTrophiesPayload() { }

        public AppliedTeamDetailsForTrophiesPayload(TeamPayload team, TeamOwnerPayload teamOwner, TrophyWithTeamPayload trophyWithTeam)
        {
            this.team = team;
            this.teamOwner = teamOwner;
            this.trophyWithTeam = trophyWithTeam;
        }

        public AppliedTeamDetailsForTrophiesPayload setDetails(TeamPayload teamPayload, TeamOwnerPayload teamOwnerPayload,
            TrophyWithTeamPayload trophyWithTeamPayload)
        {
            AppliedTeamDetailsForTrophiesPayload appliedTeamDetails = new AppliedTeamDetailsForTrophiesPayload();
            appliedTeamDetails.team = teamPayload;
            appliedTeamDetails.teamOwner = teamOwnerPayload;
            appliedTeamDetails.trophyWithTeam = trophyWithTeamPayload;
            return appliedTeamDetails;
        }

    }
}
