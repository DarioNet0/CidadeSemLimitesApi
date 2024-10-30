using CidadeSemLimites.Application.UseCases.Posts.Add;
using CidadeSemLimites.Communication.Requests.Posts;
using CidadeSemLimites.Communication.Responses.Posts;
using CidadeSemLimites.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using CidadeSemLimites.Communication.Responses.Feedback;
using CidadeSemLimites.Application.UseCases.Feedbacks.Add;
using CidadeSemLimites.Communication.Requests.Feedback;
using CidadeSemLimites.Application.UseCases.Posts.GetAll;
using CidadeSemLimites.Application.UseCases.Feedbacks.GetTop3;

namespace CidadeSemLimites.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseAddFeedbackJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(
        [FromServices] IAddFeedbackUseCase useCase,
        [FromBody] RequestAddFeedbackJson request)
        {
            var response = await useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAddFeedbackJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ListTop3 (
            [FromServices] IGetTop3FeedbackUseCase useCase
            )
        {
            var response = await useCase.Execute();

            if (response.Feedback.Count == 0)
            {
                return NoContent();
            }

            return Ok(response);
        }

    }
}
