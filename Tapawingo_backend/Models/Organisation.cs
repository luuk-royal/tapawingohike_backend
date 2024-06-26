﻿namespace Tapawingo_backend.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactEmail { get; set; }
        public ICollection<UserOrganisation> Users { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
