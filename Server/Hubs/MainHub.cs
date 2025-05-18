using Common.Base;
using Microsoft.AspNetCore.SignalR;
using Server.Database;
using Server.Models;
using Server.Services;
using System.Text.Json;

namespace Server.Hubs
{
    public class MainHub : Hub
    {
        private readonly MainDbContext _dbContext;
        private readonly MessageService _messageService;

        public MainHub(MainDbContext dbContext, MessageService service)
        {
            _dbContext = dbContext;
            _messageService = service;
        }
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveEvent", $"{Context.ConnectionId} connected");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? ex)
        {
            await Clients.All.SendAsync("ReceiveEvent", $"{Context.ConnectionId} disconnected");
            await base.OnDisconnectedAsync(ex);
        }

        public async void SendMessage(string user, string text)
        {
            await _messageService.AddAsync(user, text);

            await Clients.All.SendAsync("ReceiveEvent", $"{user}: {text}");
        }

        public async void InsertCharacter(string characterJson)
        {
            Character character = Newtonsoft.Json.JsonConvert.DeserializeObject<Character>(characterJson);

            await _dbContext.Characters.AddAsync(character);
            await _dbContext.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveEvent", $"{character.Name} added");
        }

    }
}
