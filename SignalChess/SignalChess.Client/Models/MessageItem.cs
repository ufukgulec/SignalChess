namespace SignalChess.Client.Models;

public class MessageItem
{
    public MessageItem(string username, string message)
    {
        Username = username;
        Message = message;
    }

    public string Username { get; set; }
    public string Message { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;
}
