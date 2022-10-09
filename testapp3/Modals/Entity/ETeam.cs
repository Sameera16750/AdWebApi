using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_TEAMS")]
    public class ETeam
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string createdDate { get; set; }

        [Required]
        public string lastUpdate { get; set; }
        
        [Required]
        public int status { get; set; }

        public ETeam()
        {

        }

        public ETeam(long id, string name, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public ETeam setTeamDetails(TeamPayload team)
        {
            ETeam eTeam = new ETeam();
            eTeam.id = team.id;
            eTeam.name = team.name;
            eTeam.createdDate = team.createdDate;
            eTeam.lastUpdate = team.lastUpdate;
            eTeam.status = team.status;
            return eTeam;
        }
    }
}
