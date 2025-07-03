namespace Domain.Entites
{
    public class Message
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public SenderType Sender { get; set; }
    }

}
