using Google.Protobuf.WellKnownTypes;
using testapp3.Modals.DBAuth;
using testapp3.Modals.Entity;
using testapp3.Repositories.Interfaces;

namespace testapp3.Repositories.Implements
{
    public class UserRepoImpl : IUserRepo
    {
        private readonly DBAuthContext _authContext;

        public UserRepoImpl(DBAuthContext dBAuth)
        {
           _authContext = dBAuth;
        }

        public long AddCategory(EUserTypes type)
        {
            _authContext.userTypes.Add(type);
            _authContext.SaveChanges();
            long id = type.id;
            return type.id;
        }

        public long AddInternalUser(EInsideUser eInsideUser)
        {
            _authContext.insideUsers.Add(eInsideUser);
            _authContext.SaveChanges();
            return eInsideUser.id;
        }

        public long AddTeamOwner(ETeamOwner owner)
        {
            _authContext.teamOwners.Add(owner);
            _authContext.SaveChanges();
            return owner.id;
        }

        public long AddUser(EUser user)
        {
            _authContext.users.Add(user);
            _authContext.SaveChanges();
            return user.id;
        }

        public EUser GetUserById(long id)
        {
            return _authContext.users.Find(id);
        }

        public EUserTypes getUsertypeById(long id)
        {
            return _authContext.userTypes.Find(id);
        }
    }
}
