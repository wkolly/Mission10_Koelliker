using Microsoft.EntityFrameworkCore;
using Mission10_Koelliker_Backend.DTOs;


namespace Mission10_Koelliker_Backend.Data
{
    public class EFBowlingRepository: BowlingRepository
    {
        private BowlingLeagueContext _bowlingleagecontext;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingleagecontext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlingleagecontext.Bowlers;
        public IEnumerable<BowlerWithTeamDTO> GetAllBowlersWithTeams()
        {
            var bowlersWithTeams = _bowlingleagecontext.Bowlers
                .Include(b => b.Team)
                .Select(b => new BowlerWithTeamDTO
                {
                    Id = b.BowlerId,
                    FirstName = b.BowlerFirstName,
                    LastName = b.BowlerLastName,
                    MiddleInitial = b.BowlerMiddleInit,
                    Address = b.BowlerAddress,
                    City = b.BowlerCity,
                    State = b.BowlerState,
                    Zip = b.BowlerZip,
                    PhoneNumber = b.BowlerPhoneNumber,
                    TeamName = b.Team.TeamName
                }).ToList();

            return bowlersWithTeams;
        }
    }
}
