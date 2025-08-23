using CharacterManager.Properties;
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

        public static Guid UserId { get; set; } = Settings.Default.ClientGuid;

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
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("InsertCharacter", character);
        }

        public static async Task UpdateCharacter(Character character)
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("UpdateCharacter", character);
        }

        public static async Task LevelUpCharacter(Stats stats, int level, int skillPoints, Guid characterGuid)
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("LevelUpCharacter", stats, level, skillPoints, characterGuid);
        }

        public static async Task UpdateSkills(CharacterSkills skills, Guid characterGuid)
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("UpdateSkills", skills, characterGuid);
        }
        public static async Task AddInventoryItem(InventoryItem item, Guid characterGuid)
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("AddInventoryItem", item, characterGuid);
        }
        public static async Task RemoveInventoryItem(InventoryItem item, Guid characterGuid)
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("RemoveInventoryItem", item, characterGuid);
        }
        public static async Task UpdateInventoryItem(InventoryItem item, Guid characterGuid)
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            await Connection.InvokeAsync("UpdateInventoryItem", item, characterGuid);
        }

        public static async Task<IEnumerable<Character>> GetCharacters()
        {
            if (Connection.State == HubConnectionState.Disconnected)
                await Connection.StartAsync();
            var result = await Connection.InvokeAsync<IEnumerable<Character>>("GetCharacters", UserId);
            return result;
        }
    }
}
