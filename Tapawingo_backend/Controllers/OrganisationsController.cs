﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tapawingo_backend.Dtos;
using Tapawingo_backend.Services;

namespace Tapawingo_backend.Controllers
{
    [ApiController]
    public class OrganisationsController : ControllerBase
    {
        private readonly OrganisationsService _organisationsService;

        public OrganisationsController(OrganisationsService organisationsService)
        {
            _organisationsService = organisationsService;
        }

        [Authorize]
        [HttpGet("organisations/")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrganisationDto))]
        public async Task<IActionResult> GetOrganisations()
        {
            var userClaim = User.Claims.ToArray()[5].Value;
            var organisations = await _organisationsService.GetOrganisations(userClaim);
            return organisations == null ? Ok(new List<OrganisationDto>()) : Ok(organisations);
        }

        [Authorize(Policy = "SuperAdminOrOrganisationMOrUOrEventUserPolicy")]
        [HttpGet("organisations/{organisationId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrganisationDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetOrganisation(int organisationId)
        {
            var organisation = await _organisationsService.GetOrganisationById(organisationId);
            return organisation != null ?
                Ok(organisation) :
                NotFound("Organisation with this id was not found.");
        }

        [Authorize(Policy = "SuperAdminPolicy")]
        [HttpPost("organisations/")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(OrganisationDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateOrganisation([FromBody]CreateOrganisationDto model)
        {
            if(model.Name == null || model.Name.Length == 0 || model.Name.Equals(""))
            {
                return BadRequest("Cannot create organisation without name.");
            }

            var newOrganisation = await _organisationsService.CreateOrganisation(model);
            if(newOrganisation != null)
            {
                return new ObjectResult(newOrganisation)
                {
                    StatusCode = StatusCodes.Status201Created
                };
            }
            return BadRequest("Cannot process this request.");
        }

        [Authorize(Policy = "SuperAdminOrOrganisationMPolicy")]
        [HttpPatch("organisations/{organisationId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateOrganisation(int organisationId, [FromBody]UpdateOrganisationDto model) 
        {
            var updatedOrganisation = await _organisationsService.UpdateOrganisation(organisationId, model);
            return updatedOrganisation == null ?
                NotFound(new
                {
                    message = "This organisation could not be found."
                }) :
                Ok(updatedOrganisation);
        }

        [Authorize(Policy = "SuperAdminPolicy")]
        [HttpDelete("organisations/{organisationId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteOrganisation(int organisationId)
        {
            return await _organisationsService.DeleteOrganisationAsync(organisationId);
        }
    }
}
