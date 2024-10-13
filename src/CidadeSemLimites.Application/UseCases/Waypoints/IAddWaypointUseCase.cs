using CidadeSemLimites.Communication.Requests.Waypoints;
using CidadeSemLimites.Communication.Responses.Waypoints;

namespace CidadeSemLimites.Application.UseCases.Waypoints
{
    public interface IAddWaypointUseCase
    {
        Task<ResponseAddWaypointJson> Execute(RequestAddWaypointJson request);
    }
}
