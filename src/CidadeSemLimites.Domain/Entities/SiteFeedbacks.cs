namespace CidadeSemLimites.Domain.Entities
{
    public class SiteFeedbacks
    {
        public long Id { get; set; }
        public string AvaliatorName { get; set; } = string.Empty;
        public string AvaliatorEmail { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
