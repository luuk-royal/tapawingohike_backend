﻿using Tapawingo_backend.Dtos;
using Tapawingo_backend.Models;

namespace Tapawingo_backend.Interface
{
    public interface IOrganisationsRepository
    {
        Organisation CreateOrganisation(CreateOrganisationDto createOrganisationDto);
        Organisation GetOrganisationById(int id);
        bool OrganisationExists(int id);
    }
}
