using System.Collections.Generic;
using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface IUserRepo
    {
        public long AddCategory(EUserTypes type);
        public List<EUserTypes> GetAllActiveUserTypes();
        public long AddInternalUser(EInsideUser eInsideUser);
        public EUserTypes getUsertypeById(long id);
        public long AddUser(EUser user);
        public EUser GetUserById(long id);
        public long AddTeamOwner(ETeamOwner owner);
        public long AddPlayer(EPlayer player);
        public EUser UserDetails(string uname, string pw);
    }
}
