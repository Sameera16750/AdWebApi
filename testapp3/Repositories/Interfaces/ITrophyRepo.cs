using System.Collections.Generic;
using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface ITrophyRepo
    {
        public long AddTrophy(ETrophy eTrophy);

        public List<ETrophy> GetAllActiveTrophyList();

        public long AddPlayerRequestTrophy(EPlayerWithTrophy playerWithTrophy);

        public ETrophy GetTrophyById(long id);

        public long AddTrophyWithTeam(ETrophyWithTeam trophyWithTeam);

        public long UpdateTrophyWithTeam(ETrophyWithTeam trophyWithTeam);

        public List<ETrophyWithTeam> getAllActiveTrophiesWithTeams();
    }
}
