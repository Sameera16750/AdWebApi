using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_PAYER_WITH_TROPHY")]
    public class EPlayerWithTrophy
    {
        [Key]
        public long id { get; set; }

        [Required]
        public EPlayer player { get; set; }

        [Required]
        public ETrophy trophy { get; set; }

        [Required]
        public string createdDate { get; set; }

        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int status { get; set; }

        public EPlayerWithTrophy() { }

        public EPlayerWithTrophy(long id, EPlayer player, ETrophy trophy, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.player = player;
            this.trophy = trophy;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public EPlayerWithTrophy setPlayerWithTrophyDetails(PlayerRequestTrophyPayload playerRequest,EPlayer ePlayer,ETrophy eTrophy)
        {
            EPlayerWithTrophy ePlayerWithTrophy= new EPlayerWithTrophy();
            ePlayerWithTrophy.id = playerRequest.id;
            ePlayerWithTrophy.createdDate=playerRequest.createdDate;
            ePlayerWithTrophy.lastUpdate=playerRequest.lastUpdate;
            ePlayerWithTrophy.player = ePlayer;
            ePlayerWithTrophy.trophy = eTrophy;
            ePlayerWithTrophy.status = playerRequest.status;
            return ePlayerWithTrophy;
        }

    }
}
