using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using testapp3.Modals.Entity;

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

        public UserTypePayload setUserTypeDetail(EUserTypes eUserTypes)
        {
            UserTypePayload userTypePayload = new UserTypePayload();
            userTypePayload.id = eUserTypes.id;
            userTypePayload.type = eUserTypes.type;
            userTypePayload.createdDate = eUserTypes.createdDate;
            userTypePayload.lastUpdate = eUserTypes.lastUpdate;
            userTypePayload.isDashBoardEnabled = eUserTypes.isDashBoardEnabled;
            userTypePayload.isViewPlayerEnabled = eUserTypes.isViewPlayerEnabled;
            userTypePayload.status = eUserTypes.status;
            return userTypePayload;
        }
        
        public List<UserTypePayload> setUserTypeList(List<EUserTypes> eUserTypes)
        {
            List<UserTypePayload> userTypes=new List<UserTypePayload> ();
            for(int i = 0; i < eUserTypes.Count; i++)
            {
                userTypes.Add(setUserTypeDetail(eUserTypes[i]));
            }
            return userTypes;
        }
    }
}
