using Mission10_Koelliker_Backend.DTOs;

namespace Mission10_Koelliker_Backend.Data
{
    public interface BowlingRepository
    {
      
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<BowlerWithTeamDTO> GetAllBowlersWithTeams();
    }
}
