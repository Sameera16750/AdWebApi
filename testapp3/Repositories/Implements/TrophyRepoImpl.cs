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

        public ETrophy GetTrophyById(long id)
        {
            return _authContext.trophies.Find(id);
        }

        public long AddPlayerRequestTrophy(EPlayerWithTrophy playerWithTrophy)
        {
            _authContext.playerWithTrophies.Add(playerWithTrophy);
            _authContext.SaveChanges();
            return playerWithTrophy.id;
        }

        public long AddTrophyWithTeam(ETrophyWithTeam trophyWithTeam)
        {
            _authContext.trophyWithTeams.Add(trophyWithTeam);
            _authContext.SaveChanges() ;
            return trophyWithTeam.id;
        }

        public long UpdateTrophyWithTeam(ETrophyWithTeam trophyWithTeam)
        {
            _authContext.trophyWithTeams.Update(trophyWithTeam);
            _authContext.SaveChanges () ;
            return trophyWithTeam.id;
        }
    }
}
