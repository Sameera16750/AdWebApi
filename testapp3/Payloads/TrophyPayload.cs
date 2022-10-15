using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

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

        public TrophyPayload SetTrophyPayloadDetails(ETrophy eTrophy)
        {
            TrophyPayload trophy = new TrophyPayload();
            trophy.id = eTrophy.id;
            trophy.name = eTrophy.name;
            trophy.startDate = eTrophy.startDate;
            trophy.endDate = eTrophy.endDate;
            trophy.createdDate = eTrophy.createdDate;
            trophy.lastUpdate = eTrophy.lastUpdate;
            trophy.status = eTrophy.status;

            return trophy;
        }

        public List<TrophyPayload> SetTrophyList(List<ETrophy>etrophyList)
        {
            List<TrophyPayload> trophyList = new List<TrophyPayload>();
            for (int i = 0; i < etrophyList.Count; i++)
            {
                trophyList.Add(SetTrophyPayloadDetails(etrophyList[i]));
            }
            return trophyList;
        }
    }
}
