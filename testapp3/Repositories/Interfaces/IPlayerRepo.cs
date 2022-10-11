using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface IPlayerRepo
    {
        public EPlayer GetPlayerById(long id);
    }
}
