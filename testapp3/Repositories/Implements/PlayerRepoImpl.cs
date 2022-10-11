using testapp3.Modals.DBAuth;
using testapp3.Modals.Entity;
using testapp3.Repositories.Interfaces;

namespace testapp3.Repositories.Implements
{
    public class PlayerRepoImpl:IPlayerRepo
    {
        private readonly DBAuthContext _context;

        public PlayerRepoImpl(DBAuthContext context)
        {
            _context = context;
        }

        public EPlayer GetPlayerById(long id)
        {
            return _context.player.Find(id);
        }
    }
}
