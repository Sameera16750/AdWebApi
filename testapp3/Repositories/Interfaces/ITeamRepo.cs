using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface ITeamRepo
    {
        public long AddTeam(ETeam team);
        public ETeam GetTeamById(long id);
        public ETeamOwner GetOwnerById(long id);
        public ETeamOwner GetOwnerByUser(EUser user);
        public ETeamOwner GetOwnerByTeam(ETeam team);
    }
}
