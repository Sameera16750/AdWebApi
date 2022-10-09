using System.ComponentModel.DataAnnotations;

namespace testapp3.Payloads
{
    public class TeamPayload
    {
        public long id { get; set; }
        public string name { get; set; }
        public string createdDate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public TeamPayload() { }

        public TeamPayload(long id, string name, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }
    }
}
