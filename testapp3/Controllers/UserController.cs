using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using testapp3.Payloads;
using testapp3.Services.InterFaces;

namespace testapp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser user;

        public UserController(IUser user)
        {
            this.user = user;
        }

        [HttpPost("addUserType")]
        public DefaultResponse AddUserType([FromBody]UserTypePayload userType)
        {
            return user.addUserType(userType);
        }

        [HttpGet("getAllActiveUserTypes")]
        public List<UserTypePayload> GetAllActiveUserTypes()
        {
            return user.getAllActiveUserTypes();
        }

        [HttpPost("addInternalUser")]
        public DefaultResponse AddinternalUser([FromBody]InternalUserPayload internalUser)
        {
            return user.addInternalUser(internalUser);
        }

        [HttpPost("addTeamOwner")]
        public DefaultResponse AddTeamOwner([FromBody]TeamOwnerPayload teamOwner)
        {
            return user.addTeamOwner(teamOwner);
        }

        [HttpPost("addPlayer")]
        public DefaultResponse AddPlayer([FromBody]PlayerPayload player)
        {
            return user.addPleyer(player);
        }

        [HttpPost("login")]
        public LoginResponse Login([FromBody]LoginRequest request)
        {
            return user.login(request);
        }
    }
}
