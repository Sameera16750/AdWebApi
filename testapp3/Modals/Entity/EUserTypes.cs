using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testapp3.Payloads;

namespace testapp3.Modals.Entity
{
    [Table("T_USER_TYPES")]
    public class EUserTypes
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string type{ get; set; }

        [Required]
        public string createdDate { get; set; }

        [Required]
        public string lastUpdate { get; set; }

        [Required]
        public int isDashBoardEnabled { get; set; }

        [Required]
        public int isViewPlayerEnabled { get; set; }

        [Required]
        public int status { get; set; }

        public List<EUser>Users { get; set; }

        public EUserTypes()
        {

        }

        public EUserTypes(long id, string type, string createdDate, string lastUpdate, int isDashBoardEnabled, int isViewPlayerEnabled, int status, List<EUser> users)
        {
            this.id = id;
            this.type = type;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.isDashBoardEnabled = isDashBoardEnabled;
            this.isViewPlayerEnabled = isViewPlayerEnabled;
            this.status = status;
            Users = users;
        }

        public EUserTypes setUserTypes(UserTypePayload userType)
        {
            EUserTypes eUserTypes = new EUserTypes();

            eUserTypes.id=userType.id;
            eUserTypes.type=userType.type;
            eUserTypes.isDashBoardEnabled=userType.isDashBoardEnabled;
            eUserTypes.isViewPlayerEnabled=userType.isViewPlayerEnabled;
            eUserTypes.createdDate=userType.createdDate;
            eUserTypes.lastUpdate = userType.lastUpdate;
            eUserTypes.status = userType.status;

            return eUserTypes;
        }
    }
}
