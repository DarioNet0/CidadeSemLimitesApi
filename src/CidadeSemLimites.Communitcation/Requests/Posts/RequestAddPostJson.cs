namespace CidadeSemLimites.Communication.Requests.Posts
{
    public class RequestAddPostJson
    {
        public string Neighborhood { get; set; } = string.Empty;
        public string? Street { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
