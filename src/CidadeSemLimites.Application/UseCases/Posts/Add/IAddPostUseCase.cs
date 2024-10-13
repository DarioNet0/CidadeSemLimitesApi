using CidadeSemLimites.Communication.Requests.Posts;
using CidadeSemLimites.Communication.Responses.Posts;

namespace CidadeSemLimites.Application.UseCases.Posts.Add
{
    public interface IAddPostUseCase
    {
        Task<ResponseAddPostJson> Execute(RequestAddPostJson request);
    }
}
