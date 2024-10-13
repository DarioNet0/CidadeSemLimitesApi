namespace CidadeSemLimites.Domain.Repositories.Waypoints
{
    public interface IWaypointWriteOnlyRepository
    {
        Task Add(Entities.Waypoints waypoints);
    }
}
