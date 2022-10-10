using System.Collections.Generic;
using testapp3.Payloads;

namespace testapp3.Services.InterFaces
{
    public interface IUser
    {
        public DefaultResponse addUserType(UserTypePayload userType);
        public List<UserTypePayload> getAllActiveUserTypes();
        public DefaultResponse addInternalUser(InternalUserPayload internalUser);
        public DefaultResponse addUserDetails(UserPayload userDetails);
        public DefaultResponse addTeamOwner(TeamOwnerPayload teamOwner);
        public DefaultResponse addPleyer(PlayerPayload player);
    }
}
