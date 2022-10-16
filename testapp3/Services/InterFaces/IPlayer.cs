using System.Collections.Generic;
using testapp3.Payloads;

namespace testapp3.Services.InterFaces
{
    public interface IPlayer
    {
        public List<PlayerPayload> GetSortedPlayerList(int type);
    }
}
