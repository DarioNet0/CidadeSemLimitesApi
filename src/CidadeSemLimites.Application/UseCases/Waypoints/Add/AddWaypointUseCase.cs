using AutoMapper;
using CidadeSemLimites.Communication.Requests.Waypoints;
using CidadeSemLimites.Communication.Responses.Waypoints;
using CidadeSemLimites.Domain;
using CidadeSemLimites.Domain.Repositories.Waypoints;

namespace CidadeSemLimites.Application.UseCases.Waypoints.Add
{
    public class AddWaypointUseCase : IAddWaypointUseCase
    {
        private readonly IWaypointWriteOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddWaypointUseCase(IWaypointWriteOnlyRepository repository, IUnitOfWork unityOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
            _unitOfWork = unityOfWork;
        }
        public async Task<ResponseAddWaypointJson> Execute(RequestAddWaypointJson request)
        {
            var entity = _mapper.Map<Domain.Entities.Waypoints>(request);

            await _repository.Add(entity);

            await _unitOfWork.Commit();

            var response = _mapper.Map<ResponseAddWaypointJson>(entity);

            return response;
        }
    }
}
