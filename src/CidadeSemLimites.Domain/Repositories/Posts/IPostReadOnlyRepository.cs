namespace CidadeSemLimites.Domain.Repositories.Posts
{
    public interface IPostReadOnlyRepository
    {
        Task<List<Domain.Entities.Posts>> GetAll();
        Task<List<Domain.Entities.Posts>> GetByDescription(string searchKey);
    }
}
