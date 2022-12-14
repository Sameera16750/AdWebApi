using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_USER")]
    public class EUser
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string password { get; set; }

        public EUserTypes type { get; set; }

        [Required]
        public string createdDate { get; set; }

        [Required]
        public string lastupdate { get; set; }

        [Required]
        public int status { get; set; }

        public EUser()
        {

        }

        public EUser(long id, string name, string password, EUserTypes type, string createdDate, string lastupdate, int status)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.type = type;
            this.createdDate = createdDate;
            this.lastupdate = lastupdate;
            this.status = status;
        }

        public EUser setUserDetails(UserPayload user,EUserTypes eUserTypes)
        {
            EUser eUser = new EUser();
            eUser.id = user.id;
            eUser.name= user.name;
            eUser.password= user.password;
            eUser.type = eUserTypes;
            eUser.createdDate = user.createdDate;
            eUser.lastupdate = user.lastupdate;
            eUser.status = user.status;

            return eUser;
        }
    }
}
