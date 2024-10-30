using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Communication.Requests.Feedback
{
    public class RequestAddFeedbackJson
    {
        public string AvaliatorName { get; set; } = string.Empty;
        public string AvaliatorEmail { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
