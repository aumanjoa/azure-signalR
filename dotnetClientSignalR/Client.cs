
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

public class Client
{
    private HubConnection _connection;

    public async Task Connect()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5000/chat")
            .Build();
        await _connection.StartAsync();
    }

    public async Task Broadcast()
    {
        await _connection.InvokeAsync("BroadcastMessage", "Hello World");
    }

    public async Task Stop()
    {
        await _connection.StopAsync();
    }
}