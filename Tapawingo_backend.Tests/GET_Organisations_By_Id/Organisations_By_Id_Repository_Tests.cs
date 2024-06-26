﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapawingo_backend.Data;
using Tapawingo_backend.Interface;
using Tapawingo_backend.Repository;

namespace Tapawingo_backend.Tests.GET_Organisations_By_Id
{
    [Collection("Database collection")]
    public class Organisations_By_Id_Repository_Tests : TestBase
    {
        private readonly OrganisationsRepository _organisationsRepository;
        private readonly DataContext _context;

        public Organisations_By_Id_Repository_Tests(DatabaseFixture fixture) : base(fixture)
        {
            _context = Context; //inject 'shared' context from TestBase
            _organisationsRepository = new OrganisationsRepository(_context);
        }

        //Good Weather
        [Fact]
        public async void Get_Existing_Organisation_By_Id()
        {
            var organisation = await _organisationsRepository.GetOrganisationById(1);

            Assert.NotNull(organisation);
            Assert.Equal(1, organisation.Id);
            Assert.Equal("TestOrganisation1", organisation.Name);
        }
        //


        //Bad Weather
        [Fact]
        public async void Get_Non_Existing_Organisation_By_Id()
        {
            var organisation = await _organisationsRepository.GetOrganisationById(999);

            Assert.Null(organisation);
        }
        //

        protected new void Dispose()
        {
            _context.Dispose();
        }
    }
}
