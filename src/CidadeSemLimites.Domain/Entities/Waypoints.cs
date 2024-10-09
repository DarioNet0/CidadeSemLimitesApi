using CidadeSemLimites.Domain.Enums;

namespace CidadeSemLimites.Domain.Entities
{
    public class Waypoints
    {
        public long Id { get; set; }
        public Guid UniqueIdentifier { get; set; }
        public string Name { get; set; } = string.Empty;
        public WaypointTypes WaypointType { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
