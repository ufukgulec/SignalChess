using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using SignalChess.Client.Constants;
using SignalChess.Client.Models;

namespace SignalChess.Client.Pages;

public partial class Home : IAsyncDisposable
{
    // SignalR bağlantısını tutacak değişken
    private HubConnection? hubConnection;

    // Kullanıcı mesajlarını tutacak liste
    private List<MessageItem> messages = new List<MessageItem>();

    // ChessTable'dan gelen öğeleri tutacak liste
    private List<DropItem> _items = new List<DropItem>();

    // Kullanıcıdan gelen metin inputları
    private string? userInput;
    private string? messageInput;

    // DropContainer için MudBlazor kontrolü
    MudDropContainer<DropItem> MudDropContainer;

    // OnInitializedAsync: Sayfa ilk yüklendiğinde çalışacak metod
    protected override async Task OnInitializedAsync()
    {
        // ChessTable'ın başlangıç pozisyonunu alıyoruz
        _items = ChessTable.StartingPosition();

        // SignalR Hub bağlantısını kuruyoruz
        hubConnection = new HubConnectionBuilder()
            .WithUrl(_navigationManager.ToAbsoluteUri(SignalRConstants.Url))  // Hub URL'sini belirtiyoruz
            .Build();

        // 'ReceiveMessage' adlı SignalR event'ini dinliyoruz
        hubConnection.On<string, string>(SignalRConstants.ReceiveMessage, (user, message) =>
        {
            // Yeni mesaj geldiğinde listeye ekleyip, sıralıyoruz
            messages.Add(new MessageItem(user, message));
            messages = messages.OrderByDescending(m => m.DateTime).ToList();

            // UI'yi güncellemek için InvokeAsync kullanıyoruz
            InvokeAsync(StateHasChanged);
        });

        // 'UpdateItem' event'i ile gelen yeni item'ları alıyoruz
        hubConnection.On<List<DropItem>>(SignalRConstants.UpdateItem, (items) =>
        {
            // MudDropContainer'ı ve _items listesini güncelliyoruz
            MudDropContainer.Items = items;
            _items = items;
            MudDropContainer.Refresh(); // UI'de güncellemeyi sağlıyoruz

            // UI'yi güncellemek için InvokeAsync kullanıyoruz
            InvokeAsync(StateHasChanged);
        });

        // SignalR bağlantısını başlatıyoruz
        await hubConnection.StartAsync();
    }

    // Kullanıcıdan gelen mesajı gönderen metod
    private async Task Send()
    {
        // SignalR bağlantısı mevcutsa, 'SendMessage' event'ini tetikliyoruz
        if (hubConnection is not null)
        {
            await hubConnection.SendAsync(SignalRConstants.SendMessage, userInput, messageInput);
        }
    }

    // Item güncellenmişse, bunu SignalR üzerinden gönderen metod
    private async Task ItemUpdated(MudItemDropInfo<DropItem> dropItem)
    {
        // DropItem'ı güncelliyoruz (örn. yeni yerleştirilen konumunu)
        dropItem.Item.Identifier = dropItem.DropzoneIdentifier;

        // SignalR bağlantısı mevcutsa, 'Play' event'ini tetikliyoruz
        if (hubConnection is not null)
        {
            await hubConnection.SendAsync(SignalRConstants.PlayItem, _items);
        }
    }

    // Bağlantının durumunu kontrol ederiz
    public bool IsConnected =>
        hubConnection?.State == HubConnectionState.Connected;

    // Sayfa kapanmadan önce SignalR bağlantısını düzgün şekilde kapatırız
    public async ValueTask DisposeAsync()
    {
        // SignalR bağlantısı varsa, Dispose metodunu çağırarak temizleriz
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }
}
