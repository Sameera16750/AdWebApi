using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface ITrophyRepo
    {
        public long AddTrophy(ETrophy eTrophy);

        public long PlayerRequestTrophy(EPlayerWithTrophy playerWithTrophy);

        public ETrophy GetTrophyById(long id);
    }
}
