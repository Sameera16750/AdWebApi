using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface IUserRepo
    {
        public long AddCategory(EUserTypes type);
    }
}
