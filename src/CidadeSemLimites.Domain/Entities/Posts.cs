namespace CidadeSemLimites.Domain.Entities
{
    public class Posts
    {
        public long Id { get; set; }
        public string Neighborhood { get; set; } = string.Empty;
        public string? Street { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public byte[] foto { get; set; }
    }
}
