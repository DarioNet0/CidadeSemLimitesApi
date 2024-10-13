using CidadeSemLimites.Communication.Responses.Posts;

namespace CidadeSemLimites.Application.UseCases.Posts.GetAll
{
    public interface IGetAllPostsUseCase
    {
        Task<ResponseGetPostsJson> Execute();
    }
}
