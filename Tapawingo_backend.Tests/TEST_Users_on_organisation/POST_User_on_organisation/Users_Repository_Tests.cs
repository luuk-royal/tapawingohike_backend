﻿using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapawingo_backend.Data;
using Tapawingo_backend.Dtos;
using Tapawingo_backend.Interface;
using Tapawingo_backend.Models;
using Tapawingo_backend.Repository;

namespace Tapawingo_backend.Tests.TEST_Users_on_organisation.POST_User_on_organisation
{
    [Collection("Database collection")]
    public class Users_Repository_Tests : TestBase
    {
        private readonly UsersRepository _usersRepository;
        private readonly DataContext _context;
        private readonly Mock<UserManager<User>> _userManagerMock;

        public Users_Repository_Tests(DatabaseFixture fixture) : base(fixture)
        {
            _context = Context;

            var userStoreMock = new Mock<IUserStore<User>>();
            _userManagerMock = new Mock<UserManager<User>>(userStoreMock.Object, null, null, null, null, null, null, null, null);

            _usersRepository = new UsersRepository(_context, _userManagerMock.Object);
        }

        //Good Weather
        [Fact]
        public void Create_User_On_Organisation()
        {
            CreateUserDto createUserDto = new CreateUserDto
            {
                FirstName = "test",
                LastName = "test",
                Email = "test99@gmail.nl",
                Password = "Password!1",
                IsManager = false
            };

            var user = _usersRepository.CreateUserOnOrganisation(1, createUserDto);

            Assert.NotNull(user);
        }
        //

        protected new void Dispose()
        {
            _context.Dispose();
        }
    }
}
