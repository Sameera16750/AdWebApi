using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost(Name ="addUserType")]
        public DefaultResponse AddUserType([FromBody]UserTypePayload userType)
        {
            return user.addUserType(userType);
        }
    }
}
