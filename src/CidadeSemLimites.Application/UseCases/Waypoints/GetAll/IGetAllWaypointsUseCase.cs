using CidadeSemLimites.Communication.Responses.Waypoints;

namespace CidadeSemLimites.Application.UseCases.Waypoints.GetAll
{
    public interface IGetAllWaypointsUseCase
    {
        Task<ResponseGetWaypointsJson> Execute();
    }
}
