using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
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

        public ETeamOwner GetOwnerById(long id)
        {
            try
            {
                return _authContext.teamOwners.Include(O => O.team).Where(O => O.id == id).First();
            }catch(InvalidOperationException e)
            {
                return null;
            }

        }

        public ETeamOwner GetOwnerByUser(EUser user)
        {
            try
            {
                return _authContext.teamOwners.Include(O => O.user).Include(O=>O.team).Where(O => O.user == user).First();
            }
            catch(InvalidOperationException e)
            {
                return null;
            }
        }

        public ETeam GetTeamById(long id)
        {
            return _authContext.teams.Find(id);
        }
    }
}
