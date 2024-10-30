using CidadeSemLimites.Communication.Responses.Feedback;
using CidadeSemLimites.Communication.Responses.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Application.UseCases.Feedbacks.GetTop3
{
    public interface IGetTop3FeedbackUseCase
    {
        Task<ResponseGetFeedbackJson> Execute();
    }
}
