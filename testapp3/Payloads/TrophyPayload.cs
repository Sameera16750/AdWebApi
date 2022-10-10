using System.ComponentModel.DataAnnotations;

namespace testapp3.Payloads
{
    public class TrophyPayload
    {
        public long id { get; set; }

        public string name { get; set; }

        public string startDate { get; set; }

        public string endDate { get; set; }

        public string createdDate { get; set; }

        public string lastUpdate { get; set; }

        public int status { get; set; }

        public TrophyPayload() { }

        public TrophyPayload(long id, string name, string startDate, string endDate, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }
    }
}
