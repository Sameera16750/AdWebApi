using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_TEAM_WITH_TROPHY")]
    public class ETrophyWithTeam
    {
        [Key]
        public long id { get; set; }

        [Required]
        public ETrophy trophy { get; set; }

        [Required]
        public ETeam team { get; set; }

        [Required]
        public double maxPrice { get; set; }

        [Required]
        public string createdDate { get; set; }

        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int status { get; set; }

        public ETrophyWithTeam() { }

        public ETrophyWithTeam(long id, ETrophy trophy, ETeam team, double maxPrice, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.trophy = trophy;
            this.team = team;
            this.maxPrice = maxPrice;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public ETrophyWithTeam setTrophyWithTeamDetails(TrophyWithTeamPayload trophyWithTeam, ETrophy eTrophy,ETeam eTeam)
        {
            ETrophyWithTeam eTrophyWithTeam = new ETrophyWithTeam();

            eTrophyWithTeam.id=trophyWithTeam.id;
            eTrophyWithTeam.trophy = eTrophy;
            eTrophyWithTeam.team = eTeam;
            eTrophyWithTeam.maxPrice = trophyWithTeam.maxPrice;
            eTrophyWithTeam.createdDate = trophyWithTeam.createdDate;
            eTrophyWithTeam.lastUpdate = trophyWithTeam.lastUpdate;
            eTrophyWithTeam.status = trophyWithTeam.status;

            return eTrophyWithTeam;

        }
    }
}
