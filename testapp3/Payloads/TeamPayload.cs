using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class TeamPayload
    {
        public long id { get; set; }
        public string name { get; set; }
        public string createdDate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public TeamPayload() { }

        public TeamPayload(long id, string name, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public TeamPayload setTeamPayloadDetails(ETeam eTeam)
        {
            TeamPayload team = new TeamPayload();
            team.id = eTeam.id;
            team.name = eTeam.name;
            team.createdDate = eTeam.createdDate;
            team.lastUpdate = eTeam.lastUpdate;
            team.status = eTeam.status;
            return team;
        }
    }
}
