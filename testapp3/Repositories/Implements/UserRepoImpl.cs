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
    }
}
