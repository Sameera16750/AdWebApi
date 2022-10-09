using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_TEAM_OWNER")]
    public class ETeamOwner
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string contactNo { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public int age { get; set; }

        [Required]
        public int gender { get; set; } //if gender was male then gender is =1 else gender was female then gender =2 

        [Required]
        public string address { get; set; }

        [Required]
        public string nic { get; set; }

        [Required]
        public ETeam team { get; set; }

        [Required]
        public EUser user { get; set; }

        [Required]
        public string createddate { get; set; }

        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int status { get; set; }

        public ETeamOwner()
        {

        }

        public ETeamOwner(long id, string name, string contactNo, string email, int age, int gender, string address, string nic, ETeam team, EUser user, string createddate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.contactNo = contactNo;
            this.email = email;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.nic = nic;
            this.team = team;
            this.user = user;
            this.createddate = createddate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public ETeamOwner setTeamOwnerDetails(TeamOwnerPayload teamOwner, ETeam eTeam, EUser eUser)
        {
            ETeamOwner eTeamOwner = new ETeamOwner();   
            eTeamOwner.id=teamOwner.id;
            eTeamOwner.name=teamOwner.name;
            eTeamOwner.contactNo=teamOwner.contactNo;
            eTeamOwner.email = teamOwner.email;
            eTeamOwner.age=teamOwner.age;
            eTeamOwner.gender=teamOwner.gender;
            eTeamOwner.address = teamOwner.address;
            eTeamOwner.nic=teamOwner.nic;
            eTeamOwner.team = eTeam;
            eTeamOwner.user = eUser;
            eTeamOwner.createddate = teamOwner.createddate;
            eTeamOwner.lastUpdate = teamOwner.lastUpdate;
            eTeamOwner.status = teamOwner.status;
            return eTeamOwner;
        }
    }
}
