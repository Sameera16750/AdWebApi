namespace testapp3.Payloads
{
    public class LoginResponse
    {
        public DefaultResponse configurations { get; set; }
        public UserTypePayload userType { get; set; }

        public LoginResponse() { }

        public LoginResponse(DefaultResponse configurations, UserTypePayload userType)
        {
            this.configurations = configurations;
            this.userType = userType;
        }

        public LoginResponse setLoginResponse(DefaultResponse defaultResponse,UserTypePayload userTypePayload)
        {
            LoginResponse loginResponse = new LoginResponse();
            loginResponse.configurations = defaultResponse;
            loginResponse.userType = userTypePayload;
            return loginResponse;
        }
    }
}
