using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Domain.Repositories.Feedback
{
    public interface IFeedbackWriteOnlyRepository
    {
        Task Add(Entities.SiteFeedbacks feedbackPost);
    }
}
