using System;
using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class UserImpl : IUser
    {
        IUserRepo userRepo;
        EUserTypes eUserTypes = new EUserTypes();
        EUser user = new EUser();
        EInsideUser insideUser = new EInsideUser();
        DefaultResponse defaultResponse=new DefaultResponse();

        public UserImpl(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }

        public DefaultResponse addInternalUser(InternalUserPayload internalUser)
        {
            long savedId=userRepo.AddInternalUser(insideUser.setEInsideUser(internalUser,userRepo.GetUserById(addUserDetails(internalUser.user).id)));
            if (savedId > 0)
            {
                return defaultResponse.setResponse(savedId,"User Save Success 🎉🎉🎉🎉",true);
            }
            else
            {
                return defaultResponse.setResponse(0, "<server side error> user not saved , please try again later ", false);
            }
        }

        public DefaultResponse addUserDetails(UserPayload userDetails)
        {
            EUserTypes types = userRepo.getUsertypeById(userDetails.uTypeId);
            if (types != null)
            {
                long savedId = userRepo.AddUser(user.setUserDetails(userDetails, types));
                if (savedId!>0 && savedId!=null)
                {
                    return defaultResponse.setResponse(savedId,"User saved Succes 🎉🎉🎉🎉",true);
                }
                else
                {
                    return defaultResponse.setResponse(0, "<server side error> user not saved , please try again later ", false);
                }
            }
            else
            {
                return defaultResponse.setResponse(0, "usertype not found", false);
            }
        }

        public DefaultResponse addUserType(UserTypePayload userType)
        {
            long id= userRepo.AddCategory(eUserTypes.setUserTypes(userType));
            if (id != 0)
            {
                return defaultResponse.setResponse(id, "New User type Saved 🎉🎉", true);
            }
            else
            {
                return defaultResponse.setResponse(0, "< This ServerSide error > something went wrong please try again later", true);
            }
        }
    }
}
