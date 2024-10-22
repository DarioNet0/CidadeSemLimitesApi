using AutoMapper;
using CidadeSemLimites.Communication.Responses.Waypoints;
using CidadeSemLimites.Domain.Repositories.Waypoints;

namespace CidadeSemLimites.Application.UseCases.Waypoints.GetAll
{
    public class GetAllWaypointsUseCase : IGetAllWaypointsUseCase
    {
        private readonly IWaypointsReadOnlyRepository _repository;
        private readonly IMapper _mapper;

        public GetAllWaypointsUseCase(IWaypointsReadOnlyRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ResponseGetWaypointsJson> Execute()
        {
            var waypoints = await _repository.GetAll();

            return new ResponseGetWaypointsJson
            {
                WaypointsResponse = _mapper.Map<List<ResponseGetWaypointsBaseJson>>(waypoints)
            };
        }
    }
}
