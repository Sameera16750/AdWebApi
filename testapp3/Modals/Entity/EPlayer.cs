using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_PLAYER")]
    public class EPlayer
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string name { get; set; }


        [Required]
        public int age { get; set; }

        [Required]
        public int gender { get; set; } //if gender was male then gender is =1 else gender was female then gender =2 

        [Required]
        public double height;

        [Required]
        public double weight;

        [Required]
        public string contactNo { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string nic { get; set; }

        [Required]
        public EUser user { get; set; }

        [Required]
        public string createddate { get; set; }

        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int status { get; set; }

        public EPlayer() { }

        public EPlayer(long id, string name, int age, int gender, double height, double weight, string contactNo, string address, string email, string nic, EUser user, string createddate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.contactNo = contactNo;
            this.address = address;
            this.email = email;
            this.nic = nic;
            this.user = user;
            this.createddate = createddate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public EPlayer setPlayerDetails(PlayerPayload player, EUser eUser)
        {
            EPlayer ePlayer = new EPlayer();
            ePlayer.id = player.id;
            ePlayer.name = player.name;
            ePlayer.age = player.age;
            ePlayer.gender = player.gender;
            ePlayer.height = player.height;
            ePlayer.weight = player.weight;
            ePlayer.contactNo = player.contactNo;
            ePlayer.address = player.address;
            ePlayer.email = player.email;
            ePlayer.nic = player.nic;
            ePlayer.user = eUser;
            ePlayer.createddate=player.createddate;
            ePlayer.lastUpdate = player.lastUpdate;
            ePlayer.status = player.status;
            return ePlayer;
        }
    }
}
