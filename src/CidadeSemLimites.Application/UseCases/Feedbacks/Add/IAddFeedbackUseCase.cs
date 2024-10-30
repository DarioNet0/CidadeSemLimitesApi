using CidadeSemLimites.Communication.Requests.Feedback;
using CidadeSemLimites.Communication.Requests.Waypoints;
using CidadeSemLimites.Communication.Responses.Feedback;
using CidadeSemLimites.Communication.Responses.Waypoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Application.UseCases.Feedbacks.Add
{
    public interface IAddFeedbackUseCase
    {
        Task<ResponseAddFeedbackJson> Execute(RequestAddFeedbackJson request);
    }
}
