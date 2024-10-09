namespace CidadeSemLimites.Exception
{
    public abstract class CidadeSemLimitesException : SystemException
    {
        protected CidadeSemLimitesException(string message) : base(message)
        {

        }
        public abstract int StatusCode { get; }
        public abstract List<string> GetErrors();
    }
}
