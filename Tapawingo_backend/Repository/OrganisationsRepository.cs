﻿using Tapawingo_backend.Data;
using Tapawingo_backend.Dtos;
using Tapawingo_backend.Interface;
using Tapawingo_backend.Models;

namespace Tapawingo_backend.Repository
{
    public class OrganisationsRepository : IOrganisationsRepository
    {
        private readonly DataContext _context;

        public OrganisationsRepository(DataContext context)
        {
            _context = context;
        }

        public Organisation CreateOrganisation(CreateOrganisationDto createOrganisationDto) 
        {
            var newOrganisation = new Organisation()
            {
                Name = createOrganisationDto.Name
            };
            //add the newly created element to the database without ID because it's auto-created.
            _context.Organisations.Add(newOrganisation);
            //Save changes actually saves it to the database and also it fills the rest of the object. Id is set after executing this.
            _context.SaveChanges();
            return newOrganisation;
        }

        public List<Organisation> GetAllOrganisations()
        {
            return _context.Organisations.ToList();
        }

        public Organisation GetOrganisationById(int id)
        {
            var foundOrganisation = _context.Organisations.FirstOrDefault(organisation => organisation.Id == id);
            if(foundOrganisation == null)
            {
                return null;
            }
            return foundOrganisation;
        }
        
        public bool OrganisationExists(int id)
        {
            return _context.Organisations.Any(organisation => organisation.Id == id);
        }

    }
}
