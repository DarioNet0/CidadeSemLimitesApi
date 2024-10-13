namespace CidadeSemLimites.Domain
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
