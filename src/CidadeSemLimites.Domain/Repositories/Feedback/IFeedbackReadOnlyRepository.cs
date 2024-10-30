using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeSemLimites.Domain.Repositories.Feedback
{
    public interface IFeedbackReadOnlyRepository
    {
        Task<List<Domain.Entities.SiteFeedbacks>> ListTop3();
    }
}
