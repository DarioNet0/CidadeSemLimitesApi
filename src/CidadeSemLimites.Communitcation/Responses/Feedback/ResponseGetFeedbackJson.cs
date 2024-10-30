using CidadeSemLimites.Communication.Responses.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Communication.Responses.Feedback
{
    public class ResponseGetFeedbackJson
    {
        public List<ResponseGetFeedbackBaseJson> Feedback { get; set; } = [];
    }
}
