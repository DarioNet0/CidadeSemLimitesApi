using AutoMapper;
using CidadeSemLimites.Communication.Responses.Posts;
using CidadeSemLimites.Domain.Repositories.Posts;

namespace CidadeSemLimites.Application.UseCases.Posts.GetAll
{
    public class GetAllPostsUseCase : IGetAllPostsUseCase
    {
        private readonly IPostReadOnlyRepository _repository;
        private readonly IMapper _mapper;
        public GetAllPostsUseCase(
            IPostReadOnlyRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ResponseGetPostsJson> Execute()
        {
            var Posts = await _repository.GetAll();

            return new ResponseGetPostsJson
            {
                Posts = _mapper.Map<List<ResponseGetPostsBaseJson>>(Posts)
            };
        }
    }
}
