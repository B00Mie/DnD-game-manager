using Common.Base;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CharacterManager.Implementations.Singletones
{
    public static class SignalRClient
    {
        public static readonly HubConnection Connection =
            new HubConnectionBuilder()
                .WithUrl("https://localhost:7152/hubs/main")
                .WithAutomaticReconnect()
                .Build();

        public static async Task InitializeAsync()
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
        }

        public static async Task SendMessageAsync(string user, string text)
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("SendMessage", user, text);
        }

        public static async Task InsertCharacter(Character character)
        {
            string characterJson = Newtonsoft.Json.JsonConvert.SerializeObject(character);
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("InsertCharacter", characterJson);
        }
    }
}
