using System.ComponentModel.DataAnnotations;

namespace Tapawingo_backend.Dtos
{
    public class CreateTeamDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string ContactName { get; set; }
        [EmailAddress]
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public bool Online { get; set; }
    }
}
