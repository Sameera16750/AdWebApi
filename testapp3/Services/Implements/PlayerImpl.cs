using System.Collections.Generic;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class PlayerImpl : IPlayer
    {
        IPlayerRepo playerRepo;

        public PlayerImpl(IPlayerRepo playerRepo)
        {
            this.playerRepo = playerRepo;
        }

        public List<PlayerPayload> GetSortedPlayerList(int type)
        {
            throw new System.NotImplementedException();
        }
    }
}
