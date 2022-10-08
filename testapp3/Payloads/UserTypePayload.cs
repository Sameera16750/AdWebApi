using System.ComponentModel.DataAnnotations;

namespace testapp3.Payloads
{
    public class UserTypePayload
    {
        public long id { get; set; }

        public string type { get; set; }

        public string createdDate { get; set; }

        public string lastUpdate { get; set; }

        public int isDashBoardEnabled { get; set; }

        public int isViewPlayerEnabled { get; set; }

        public int status { get; set; }

        public UserTypePayload()
        {

        }

       public UserTypePayload(long id, string type, string createdDate, string lastUpdate, int isDashBoardEnabled, int isViewPlayerEnabled, int status)
        {
            this.id = id;
            this.type = type;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.isDashBoardEnabled = isDashBoardEnabled;
            this.isViewPlayerEnabled = isViewPlayerEnabled;
            this.status = status;
        }
    }
}
