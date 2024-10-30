using AutoMapper;
using CidadeSemLimites.Domain.Repositories.Posts;
using CidadeSemLimites.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CidadeSemLimites.Communication.Requests.Waypoints;
using CidadeSemLimites.Communication.Responses.Waypoints;
using CidadeSemLimites.Communication.Responses.Feedback;
using CidadeSemLimites.Communication.Requests.Feedback;
using CidadeSemLimites.Domain.Repositories.Feedback;

namespace CidadeSemLimites.Application.UseCases.Feedbacks.Add
{
    public class AddFeedbackUseCase : IAddFeedbackUseCase
    {
        private readonly IFeedbackWriteOnlyRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public AddFeedbackUseCase(
            IFeedbackWriteOnlyRepository repository,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task<ResponseAddFeedbackJson> Execute(RequestAddFeedbackJson request)
        {
            var entity = _mapper.Map<Domain.Entities.SiteFeedbacks>(request);

            await _repository.Add(entity);

            await _unitOfWork.Commit();

            var response = _mapper.Map<ResponseAddFeedbackJson>(entity);

            return response;
        }


    }

}
