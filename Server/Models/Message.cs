namespace Server.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string User { get; set; } = default!;
        public string Text { get; set; } = default!;
        public DateTime SentAt { get; set; }
    }
}
