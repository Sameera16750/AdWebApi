using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_TROPHY")]
    public class ETrophy
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string startDate { get; set; }

        [Required]
        public string endDate { get; set; }

        [Required]
        public string createdDate { get; set; }

        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int status { get; set; }

        public ETrophy() { }

        public ETrophy(long id, string name, string startDate, string endDate, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public ETrophy SetTrophyDetails(TrophyPayload trophyPayload)
        {
            ETrophy eTrophy= new ETrophy();
            eTrophy.id=trophyPayload.id;
            eTrophy.name=trophyPayload.name;
            eTrophy.startDate=trophyPayload.startDate;
            eTrophy.endDate=trophyPayload.endDate;
            eTrophy.createdDate=trophyPayload.createdDate;
            eTrophy.lastUpdate=trophyPayload.lastUpdate;
            eTrophy.status=trophyPayload.status;
            return eTrophy;
        }
    }
}
