﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapawingo_backend.Data;
using Tapawingo_backend.Dtos;
using Tapawingo_backend.Interface;
using Tapawingo_backend.Repository;
using Tapawingo_backend.Services;

namespace Tapawingo_backend.Tests.PUT_Organisations
{
    [Collection("Database collection")]
    public class PUT_Organisations_Repository_Tests : TestBase
    {
        private readonly OrganisationsRepository _organisationsRepository;
        private readonly DataContext _context;

        public PUT_Organisations_Repository_Tests(DatabaseFixture fixture) : base(fixture)
        {
            _context = Context; //inject 'shared' context from TestBase
            _organisationsRepository = new OrganisationsRepository(_context);
        }

        //Good Weather
        [Fact]
        public async void Update_A_Organisation_By_One_Element()
        {

            //before update
            var oldOrganisation = await _organisationsRepository.GetOrganisationById(3);

            Assert.NotNull(oldOrganisation);
            Assert.Equal("TestForUpdate", oldOrganisation.Name);

            //updating...
            var newOrganisationModel = new UpdateOrganisationDto
            {
                Name = "YetAnotherName"
            };

            await _organisationsRepository.UpdateOrganisationAsync(3, newOrganisationModel);

            //after update
            var newOrganisation = await _organisationsRepository.GetOrganisationById(3);
            Assert.NotNull(newOrganisation);
            Assert.Equal("YetAnotherName", newOrganisation.Name);
            Assert.Equal(oldOrganisation.ContactEmail, newOrganisation.ContactEmail);
            Assert.Equal(oldOrganisation.ContactPerson, newOrganisation.ContactPerson);
        }
        //

        protected new void Dispose()
        {
            _context.Dispose();
        }
    }
}
