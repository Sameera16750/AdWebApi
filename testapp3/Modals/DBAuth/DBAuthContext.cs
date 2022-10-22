using Microsoft.EntityFrameworkCore;
using testapp3.Modals.Entity;

namespace testapp3.Modals.DBAuth
{
    public class DBAuthContext:DbContext
    {
        public DBAuthContext(DbContextOptions<DBAuthContext> options) : base(options)
        {

        }
        public DbSet<EEmployee> employee { get; set; }
        public DbSet<EUserTypes> userTypes { get; set; }
        public DbSet<EUser> users { get; set; }
        public DbSet<EInsideUser> insideUsers { get; set; }
        public DbSet<ETeamOwner>teamOwners { get; set; }
        public DbSet<ETeam>teams { get; set; }  
        public DbSet<EPlayer> player { get; set; }
        public DbSet<ETrophy> trophies { get; set; }
        public DbSet<EPlayerWithTrophy>playerWithTrophies { get; set; }
        public DbSet<ETrophyWithTeam> trophyWithTeams { get; set; }
        public DbSet<EBidding> biddings { get; set; }

    }
}
