using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Communication.Responses.Feedback
{
    public class ResponseAddFeedbackJson
    {
        public long Id { get; set; }
        public string AvaliatorName { get; set; } = string.Empty;
    }
}
