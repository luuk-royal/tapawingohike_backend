﻿namespace Tapawingo_backend.Models
{
    public class Routepart
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public TWRoute Route { get; set; }
        public string Name { get; set; }
        public string RouteType { get; set; }
        public bool RoutepartZoom { get; set; }
        public bool RoutepartFullscreen { get; set; }
        public int Order { get; set; }
        public bool Final { get; set; }
        public ICollection<TeamRoutepart> TeamRouteparts { get; set; }
        public ICollection<Destination> Destinations { get; set; }
        public ICollection<TWFile> Files { get; set; }
    }
}
