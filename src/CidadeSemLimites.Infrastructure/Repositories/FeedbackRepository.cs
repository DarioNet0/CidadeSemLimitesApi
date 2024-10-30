using CidadeSemLimites.Domain.Entities;
using CidadeSemLimites.Domain.Repositories.Posts;
using CidadeSemLimites.Domain.Repositories;
using CidadeSemLimites.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CidadeSemLimites.Domain.Repositories.Feedback;
using Microsoft.EntityFrameworkCore;

namespace CidadeSemLimites.Infrastructure.Repositories
{
    public class FeedbackRepository : IFeedbackReadOnlyRepository, IFeedbackUpdateOnlyRepository, IFeedbackWriteOnlyRepository
    {
        private readonly CidadeSemLimitesDbContext _dbContext;
        public FeedbackRepository(CidadeSemLimitesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(SiteFeedbacks FeedbackPost)
        {
            await _dbContext.SiteFeedbacks.AddAsync(FeedbackPost);
        }
        public async Task<List<SiteFeedbacks>> ListTop3()
        {
          return  await _dbContext.SiteFeedbacks
           .OrderByDescending(e => e.CreatedAt)
           .Take(3)
           .ToListAsync();
        }
    }
}
