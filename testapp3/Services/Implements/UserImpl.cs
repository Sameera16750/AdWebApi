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
        DefaultResponse defaultResponse=new DefaultResponse();

        public UserImpl(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
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
