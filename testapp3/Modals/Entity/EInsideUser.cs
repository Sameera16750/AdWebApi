using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testapp3.Modals.Entity
{
    [Table("T_INSIDE_USERS")]
    public class EInsideUser
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

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
            Id = id;
            Name = name;
            this.contactNo = contactNo;
            this.address = address;
            this.user = user;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }
    }
}
