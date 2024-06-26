﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapawingo_backend.Data;
using Tapawingo_backend.Interface;
using Tapawingo_backend.Repository;

namespace Tapawingo_backend.Tests.GET_Routes
{
    [Collection("Database collection")]
    public class Routes_Repository_Tests : TestBase
    {
        private readonly RoutesRepository _routesRepository;
        private readonly DataContext _context;

        public Routes_Repository_Tests(DatabaseFixture fixture) : base(fixture)
        {
            _context = Context; //inject 'shared' context from TestBase
            _routesRepository = new RoutesRepository(_context);
        }

        //Good Weather
        [Fact]
        public async void Get_All_Routes_On_Edition()
        {
            var routes = await _routesRepository.GetRoutesOnEditionAsync(2);

            Assert.NotNull(routes);
            Assert.Equal(2, routes.Count());
            Assert.Equal(2, routes[0].Id);
            Assert.Equal(3, routes[1].Id);
            Assert.Equal("TestRoute2", routes[0].Name);
            Assert.Equal("TestRoute3", routes[1].Name);
        }
        //

        protected new void Dispose()
        {
            _context.Dispose();
        }
    }
}
