namespace testapp3.Payloads
{
    public class InternalUserPayload
    {
        public long id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string contactNo { get; set; }

        public string address { get; set; }

        public UserPayload user { get; set; }

        public string createdDate { get; set; }

        public string lastUpdate { get; set; }

        public int status { get; set; }

        public InternalUserPayload()
        {

        }

        public InternalUserPayload(long id, string name, string email, string contactNo, string address, UserPayload user, string createdDate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.contactNo = contactNo;
            this.address = address;
            this.user = user;
            this.createdDate = createdDate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }
    }
}
