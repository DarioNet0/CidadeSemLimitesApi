using CidadeSemLimites.Communication.Responses.Posts;

namespace CidadeSemLimites.Application.UseCases.Posts.GetByDescription
{
    public interface IGetPostByDescriptionUseCase
    {
        Task<ResponseGetPostsJson> Execute(string searchKey);
    }
}
