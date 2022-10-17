using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class TrophyWithTeamPayload
    {
        public long id { get; set; }
        public long trophyId { get; set; }
        public long teamId { get; set; }
        public double maxPrice { get; set; }
        public string createdDate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public TrophyWithTeamPayload() { }

        public TrophyWithTeamPayload(long id, long trophyId, long teamId, double maxPrice, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.trophyId = trophyId;
            this.teamId = teamId;
            this.maxPrice = maxPrice;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public TrophyWithTeamPayload setDetails(ETrophyWithTeam eTrophyWithTeam)
        {
            TrophyWithTeamPayload trophyWithTeam = new TrophyWithTeamPayload();
            trophyWithTeam.id = eTrophyWithTeam.id;
            trophyWithTeam.trophyId=eTrophyWithTeam.trophy.id;
            trophyWithTeam.teamId = eTrophyWithTeam.team.id;
            trophyWithTeam.maxPrice = eTrophyWithTeam.maxPrice;
            trophyWithTeam.createdDate = eTrophyWithTeam.createdDate;
            trophyWithTeam.lastUpdate = eTrophyWithTeam.lastUpdate;
            trophyWithTeam.status = eTrophyWithTeam.status;
            return trophyWithTeam;
        }
    }
}
