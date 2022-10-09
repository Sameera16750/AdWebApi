using testapp3.Modals.DBAuth;
using testapp3.Modals.Entity;
using testapp3.Repositories.Interfaces;

namespace testapp3.Repositories.Implements
{
    public class TeamRepoImpl : ITeamRepo
    {
        private readonly DBAuthContext _authContext;

        public TeamRepoImpl(DBAuthContext authContext)
        {
            _authContext = authContext;
        }

        public long AddTeam(ETeam team)
        {
            _authContext.Add(team);
            _authContext.SaveChanges();
            return team.id;
        }

        public ETeam GetTeamById(long id)
        {
            return _authContext.teams.Find(id);
        }
    }
}
