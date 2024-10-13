using CidadeSemLimites.Application.UseCases.Posts.Add;
using CidadeSemLimites.Application.UseCases.Posts.GetAll;
using CidadeSemLimites.Application.UseCases.Posts.GetByDescription;
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
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseGetPostsJson), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll(
            [FromServices] IGetAllPostsUseCase useCase
            )
        {
            var response = await useCase.Execute();

            if (response.Posts.Count == 0)
            {
                return NoContent();
            }

            return Ok(response);
        }
        [HttpGet]
        [Route("{searchKey}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseGetPostsJson), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByDescription(
            [FromRoute] string searchKey,
            [FromServices] IGetPostByDescriptionUseCase useCase)
        {
            var response = await useCase.Execute(searchKey);

            if (response.Posts.Count == 0)
            {
                return NoContent();
            }

            return Ok(response);
        }
    }
}
