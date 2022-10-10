using testapp3.Modals.DBAuth;
using testapp3.Modals.Entity;
using testapp3.Repositories.Interfaces;

namespace testapp3.Repositories.Implements
{
    public class TrophyRepoImpl : ITrophyRepo
    {
        private readonly DBAuthContext _authContext;

        public TrophyRepoImpl(DBAuthContext authContext)
        {
            _authContext = authContext;
        }

        public long AddTrophy(ETrophy eTrophy)
        {
            _authContext.trophies.Add(eTrophy);
            _authContext.SaveChanges();
            return eTrophy.id;
        }
    }
}
