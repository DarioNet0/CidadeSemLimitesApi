using AutoMapper;
using CidadeSemLimites.Communication.Responses.Posts;
using CidadeSemLimites.Domain.Repositories.Posts;

namespace CidadeSemLimites.Application.UseCases.Posts.GetByDescription
{
    public class GetPostByDescriptionUseCase : IGetPostByDescriptionUseCase
    {
        private readonly IPostReadOnlyRepository _repository;
        private readonly IMapper _mapper;
        public GetPostByDescriptionUseCase(
            IPostReadOnlyRepository repository,
            IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ResponseGetPostsJson> Execute(string searchKey)
        {
            var posts = await _repository.GetByDescription(searchKey);

            return new ResponseGetPostsJson
            {
                Posts = _mapper.Map<List<ResponseGetPostsBaseJson>>(posts)
            };
        }
    }
}
