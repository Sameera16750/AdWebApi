using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class UserPayload
    {

        public long id { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        public UserTypePayload type { get; set; }

        public string createdDate { get; set; }

        public string lastupdate { get; set; }

        public int status { get; set; }

        public UserPayload()
        {

        }

        public UserPayload(long id, string name, string password, UserTypePayload type, string createdDate, string lastupdate, int status)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.type = type;
            this.createdDate = createdDate;
            this.lastupdate = lastupdate;
            this.status = status;
        }
    }
}
