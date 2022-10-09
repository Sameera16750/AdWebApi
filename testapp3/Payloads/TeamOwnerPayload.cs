using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class TeamOwnerPayload
    {
        public long id { get; set; }
        public string name { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public int gender { get; set; } //if gender was male then gender is =1 else gender was female then gender =2 
        public string address { get; set; }
        public string nic { get; set; }
        public TeamPayload team { get; set; }
        public UserPayload user { get; set; }
        public string createddate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public TeamOwnerPayload() { }

        public TeamOwnerPayload(long id, string name, string contactNo, string email, int age, int gender, string address, string nic, TeamPayload team, UserPayload user, string createddate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.contactNo = contactNo;
            this.email = email;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.nic = nic;
            this.team = team;
            this.user = user;
            this.createddate = createddate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }
    }
}
