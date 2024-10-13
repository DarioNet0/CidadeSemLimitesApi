using CidadeSemLimites.Application.UseCases.Posts.Add;
using CidadeSemLimites.Communication.Requests.Posts;
using CidadeSemLimites.Communication.Responses;
using CidadeSemLimites.Communication.Responses.Posts;
using Microsoft.AspNetCore.Mvc;

namespace CidadeSemLimites.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseAddPostJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(
            [FromServices] IAddPostUseCase useCase,
            [FromBody] RequestAddPostJson request)
        {
            var response = await useCase.Execute(request);

            return Created(string.Empty, response);
        }
    }
}
