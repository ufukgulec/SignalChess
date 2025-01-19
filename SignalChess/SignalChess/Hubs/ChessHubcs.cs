using Microsoft.AspNetCore.SignalR;
using SignalChess.Client.Constants;
using SignalChess.Client.Models;

namespace SignalChess.Hubs;

public class ChessHubs : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync(SignalRConstants.ReceiveMessage, user, message);
    }
    public async Task PlayItem(List<DropItem> dropItem)
    {
        await Clients.All.SendAsync(SignalRConstants.UpdateItem, dropItem);
    }
}
