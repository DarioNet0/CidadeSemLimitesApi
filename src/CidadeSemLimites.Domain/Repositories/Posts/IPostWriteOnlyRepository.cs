namespace CidadeSemLimites.Domain.Repositories.Posts
{
    public interface IPostWriteOnlyRepository
    {
        Task Add(Entities.Posts post);
    }
}
