﻿namespace Tapawingo_backend.Dtos
{
    public class UpdateDestinationDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Radius { get; set; }
        public string DestinationType { get; set; }
        public bool ConfirmByUser { get; set; }
        public bool HideForUser { get; set; }
    }
}
