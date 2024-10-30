using AutoMapper;
using CidadeSemLimites.Communication.Responses.Feedback;
using CidadeSemLimites.Communication.Responses.Posts;
using CidadeSemLimites.Domain.Entities;
using CidadeSemLimites.Domain.Repositories.Feedback;
using CidadeSemLimites.Domain.Repositories.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Application.UseCases.Feedbacks.GetTop3
{
    public class GetTop3FeedbackUseCase : IGetTop3FeedbackUseCase
    {
        private readonly IFeedbackReadOnlyRepository _repository;
        private readonly IMapper _mapper;
        public GetTop3FeedbackUseCase(
            IFeedbackReadOnlyRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResponseGetFeedbackJson> Execute()
        {
            var Feedback = await _repository.ListTop3();
            
            return new ResponseGetFeedbackJson
            {
                Feedback = _mapper.Map<List<ResponseGetFeedbackBaseJson>>(Feedback)
            };
        }
    }
}
