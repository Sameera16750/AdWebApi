﻿using testapp3.Payloads;

namespace testapp3.Services.InterFaces
{
    public interface ITeam
    {
        public DefaultResponse AddTeam(TeamPayload team);
    }
}
