namespace Domain.Entities
{

public class Message
{
    public Guid Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public string Sender { get; set; } = "User";

    public static Message CreateUserMessage(string text)
    {
        return new Message
        {
            Id = Guid.NewGuid(),
            Text = text,
            Timestamp = DateTime.UtcNow,
            Sender = "User"
        };
    }

    public static Message CreateBotMessage(string text)
    {
        return new Message
        {
            Id = Guid.NewGuid(),
            Text = text,
            Timestamp = DateTime.UtcNow,
            Sender = "Bot"
        };
    }
}


}