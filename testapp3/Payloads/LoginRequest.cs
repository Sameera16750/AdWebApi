﻿namespace testapp3.Payloads
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginRequest() { }

        public LoginRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
