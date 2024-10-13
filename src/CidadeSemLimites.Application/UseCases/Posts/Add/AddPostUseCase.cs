using AutoMapper;
using CidadeSemLimites.Application.Validators.Posts;
using CidadeSemLimites.Communication.Requests.Posts;
using CidadeSemLimites.Communication.Responses.Posts;
using CidadeSemLimites.Domain;
using CidadeSemLimites.Domain.Repositories.Posts;
using CidadeSemLimites.Exception.ExceptionBase;

namespace CidadeSemLimites.Application.UseCases.Posts.Add
{
    public class AddPostUseCase : IAddPostUseCase
    {
        private readonly IPostWriteOnlyRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public AddPostUseCase(
            IPostWriteOnlyRepository repository,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task<ResponseAddPostJson> Execute(RequestAddPostJson request)
        {
            Validate(request);

            var entity = _mapper.Map<Domain.Entities.Posts>(request);

            await _repository.Add(entity);

            await _unitOfWork.Commit();

            var response = _mapper.Map<ResponseAddPostJson>(entity);

            return response;
        }
        private void Validate(RequestAddPostJson request)
        {
            var validator = new PostValidator();
            var result = validator.Validate(request);
            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
