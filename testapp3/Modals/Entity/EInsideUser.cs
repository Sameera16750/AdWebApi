using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_INSIDE_USERS")]
    public class EInsideUser
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string contactNo { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public EUser user { get; set; }

        [Required]
        public string createdDate { get; set; }

        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int status { get; set; }

        public EInsideUser()
        {

        }

        public EInsideUser(long id, string name, string contactNo, string address, EUser user, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.contactNo = contactNo;
            this.address = address;
            this.user = user;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }

        public EInsideUser setEInsideUser(InternalUserPayload internalUser, EUser eUser)
        {
            EInsideUser eInsideUser = new EInsideUser();
            eInsideUser.id = internalUser.id;
            eInsideUser.name = internalUser.name;
            eInsideUser.contactNo = internalUser.contactNo;
            eInsideUser.address = internalUser.address;
            eInsideUser.user = eUser;
            eInsideUser.createdDate = internalUser.createdDate;
            eInsideUser.lastUpdate = internalUser.lastUpdate;
            eInsideUser.status = internalUser.status;

            return eInsideUser;

        }
    }
}
