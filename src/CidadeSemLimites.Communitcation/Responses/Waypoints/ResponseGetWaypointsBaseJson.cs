using CidadeSemLimites.Application.Enums;

namespace CidadeSemLimites.Communication.Responses.Waypoints
{
    public class ResponseGetWaypointsBaseJson
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public WaypointsTypes WaypointType { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
