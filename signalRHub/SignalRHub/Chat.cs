using Microsoft.AspNetCore.SignalR;

    public class Chat : Hub
    {
        public void BroadcastMessage(string name)
        {
            Clients.All.SendAsync("BroadcastMessage", name);
        }
    }