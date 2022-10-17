using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class UserPayload
    {

        public long id { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        public long uTypeId { get; set; }

        public string createdDate { get; set; }

        public string lastupdate { get; set; }

        public int status { get; set; }

        public UserPayload()
        {

        }

        public UserPayload(long id, string name, string password, long uTypeId, string createdDate, string lastupdate, int status)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.uTypeId = uTypeId;
            this.createdDate = createdDate;
            this.lastupdate = lastupdate;
            this.status = status;
        }

        public UserPayload setDetails(EUser eUser)
        {
            UserPayload user = new UserPayload();
            user.id = eUser.id;
            user.name = eUser.name;
            user.password = eUser.password;
            user.uTypeId = eUser.type.id;
            user.createdDate= eUser.createdDate;
            user.lastupdate = eUser.lastupdate;
            user.status = eUser.status;
            return user;
        }
    }
}
