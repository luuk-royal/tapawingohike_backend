﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapawingo_backend.Data;
using Tapawingo_backend.Repository;
using Tapawingo_backend.Services;
using AutoMapper;
using Tapawingo_backend.Helper;

namespace Tapawingo_backend.Tests.GET_Routes
{
    [Collection("Database collection")]
    public class Routes_Service_Tests : TestBase
    {
        private readonly RoutesRepository _routesRepository;
        private readonly EditionsRepository _editionsRepository;
        private readonly RoutesService _routesService;
        private readonly DataContext _context;

        public Routes_Service_Tests(DatabaseFixture fixture) : base(fixture)
        {
            _context = Context; //inject 'shared' context from TestBase
            //Create a repository that works on the TEST DATABASE!!
            _routesRepository = new RoutesRepository( _context );
            _editionsRepository = new EditionsRepository(_context );
            //Create a instance of the IMapper.
            _routesService = new RoutesService(_routesRepository, _editionsRepository, new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            }).CreateMapper());
        }

        //Good Weather
        [Fact]
        public async void Get_All_Routes_On_Edition()
        {
            var routes = await _routesService.GetRoutesOnEditionAsync(2);

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
