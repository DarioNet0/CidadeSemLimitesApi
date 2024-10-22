namespace CidadeSemLimites.Domain.Repositories.Waypoints
{
    public interface IWaypointsReadOnlyRepository
    {
        Task<List<Entities.Waypoints>> GetAll();
    }
}
