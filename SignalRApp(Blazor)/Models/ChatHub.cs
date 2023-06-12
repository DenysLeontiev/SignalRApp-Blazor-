using Microsoft.AspNetCore.SignalR;

namespace SignalRApp_Blazor_.Models
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string username , string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", username, message);
        }
    }
}
