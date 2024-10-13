using CidadeSemLimites.Application.UseCases.Waypoints;
using CidadeSemLimites.Communication.Requests.Waypoints;
using Microsoft.AspNetCore.Mvc;

namespace CidadeSemLimites.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaypointController : ControllerBase
    {
        [HttpPost]

        public async Task<IActionResult> Add(
            [FromServices] IAddWaypointUseCase useCase,
            [FromBody] RequestAddWaypointJson request)
        {
            var reponse = await useCase.Execute(request);

            return Created(string.Empty, reponse);
        }
    }
}
