using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface IUserRepo
    {
        public long AddCategory(EUserTypes type);
        public long AddInternalUser(EInsideUser eInsideUser);
        public EUserTypes getUsertypeById(long id);
        public long AddUser(EUser user);
        public EUser GetUserById(long id);
        public long AddTeamOwner(ETeamOwner owner);
    }
}
