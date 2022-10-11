namespace testapp3.Payloads
{
    public class PlayerRequestTrophyPayload
    {
        public long id { get; set; }
        public long playerId { get; set; }
        public long trophyId { get; set; }
        public string createdDate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public PlayerRequestTrophyPayload() { }

        public PlayerRequestTrophyPayload(long id, long playerId, long trophyId, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.playerId = playerId;
            this.trophyId = trophyId;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }
    }
}
