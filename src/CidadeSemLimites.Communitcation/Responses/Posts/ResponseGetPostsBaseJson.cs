namespace CidadeSemLimites.Communication.Responses.Posts
{
    public class ResponseGetPostsBaseJson
    {
        public long Id { get; set; }
        public string Neighborhood { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
