using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

namespace testapp3.Payloads
{
    public class PlayerPayload
    {
        public long id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int gender { get; set; } //if gender was male then gender is =1 else gender was female then gender =2 
        public double height;
        public double weight;
        public string contactNo { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string nic { get; set; }
        public UserPayload user { get; set; }
        public string createddate { get; set; }
        public string lastUpdate { get; set; }
        public int status { get; set; }

        public PlayerPayload() { }

        public PlayerPayload(long id, string name, int age, int gender, double height, double weight, string contactNo, string address, string email, string nic, UserPayload user, string createddate, string lastUpdate, int status)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.contactNo = contactNo;
            this.address = address;
            this.email = email;
            this.nic = nic;
            this.user = user;
            this.createddate = createddate;
            this.lastUpdate = lastUpdate;
            this.status = status;
        }
    }
}
