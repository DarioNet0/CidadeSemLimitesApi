namespace CidadeSemLimites.Communication.Responses.Feedback
{
    public class ResponseGetFeedbackBaseJson
    {
        public long Id { get; set; }
        public string AvaliatorName { get; set; } = string.Empty;
        public string AvaliatorEmail { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
