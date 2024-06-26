using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Xunit;
using Tapawingo_backend.Data;
using Tapawingo_backend.Interface;
using Tapawingo_backend.Repository;
using Tapawingo_backend.Dtos;
using Tapawingo_backend.Models;

namespace Tapawingo_backend.Tests.TEST_Teams.POST_Teams
{
    [Collection("Database collection")]
    public class Teams_Repository_Tests : TestBase
    {
        private readonly TeamRepository _teamsRepository;
        private readonly DataContext _context;

        public Teams_Repository_Tests(DatabaseFixture fixture) : base(fixture)
        {
            _context = Context;
            _teamsRepository = new TeamRepository(_context);
        }

        // Good Weather
        [Fact]
        public async Task Post_Team_Successful()
        {
            var team = new CreateTeamDto()
            {
                Name = "Test Team",
                Code = "TST001",
                ContactName = "John Doe",
                ContactEmail = "john.doe@example.com",
                ContactPhone = "1234567890",
                Online = true,
            };

            var createdTeam = await _teamsRepository.CreateTeamOnEditionAsync(1, team);

            Assert.NotNull(createdTeam);
            Assert.Equal(team.Name, createdTeam.Name);
            Assert.Equal(team.Code, createdTeam.Code);
            Assert.Equal(team.ContactName, createdTeam.ContactName);
            Assert.Equal(team.ContactEmail, createdTeam.ContactEmail);
            Assert.Equal(team.ContactPhone, createdTeam.ContactPhone);
            Assert.Equal(team.Online, createdTeam.Online);
            Assert.Equal(1, createdTeam.EditionId);
        }

        protected new void Dispose()
        {
            _context.Dispose();
        }
    }
}
