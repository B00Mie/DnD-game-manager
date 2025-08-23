using Common.Base;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Server.Database;
using Server.Migrations;
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

        public async void InsertCharacter(Character character)
        {
            character.Race = null;

            await _dbContext.Characters.AddAsync(character);
            await _dbContext.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveEvent", $"{character.Name} added");
        }

        public async void UpdateCharacter(Character character)
        {
            var existingCharacter = await _dbContext.Characters
                                                    .Include(c => c.Stats)
                                                    .FirstOrDefaultAsync(c => c.Id == character.Id);
            if (existingCharacter != null)
            {
                existingCharacter.Skills = character.Skills;
                existingCharacter.SkillPoints = character.SkillPoints;
                existingCharacter.Stats = character.Stats;
                await _dbContext.SaveChangesAsync();
                await Clients.All.SendAsync("ReceiveEvent", $"{character.Name} updated");
            }
            else
            {
                await Clients.All.SendAsync("ReceiveEvent", $"Character not found");
            }
        }

        public async void LevelUpCharacter(Stats stats, int level, int skillPoints, Guid charaterGuid)
        {
            await _dbContext.Characters
                        .Where(c => c.Guid == charaterGuid)
                        .ExecuteUpdateAsync(upd => upd
                            .SetProperty(c => c.Stats.Intelligence, _ => stats.Intelligence)
                            .SetProperty(c => c.Stats.Strength, _ => stats.Strength)
                            .SetProperty(c => c.Stats.Agility, _ => stats.Agility)
                            .SetProperty(c => c.Stats.Utility, _ => stats.Utility)
                            .SetProperty(c => c.Level, _ => level)
                            .SetProperty(c => c.SkillPoints, _ => skillPoints)
                        );
        }

        public async void UpdateSkills(CharacterSkills skills, Guid charaterGuid)
        {
            var character = await _dbContext.Characters
            .Include(c => c.Skills)
                             .FirstAsync(c => c.Guid == charaterGuid);

            _dbContext.Skills.RemoveRange(character.Skills);

            // create new
            character.Skills = skills.Skills.Select(d => new Skill
            {
                CharacterId = character.Id,
                SkillGroup = d.SkillGroup,
                Name = d.Name,
                Level = d.Level
            }).ToList();
            character.SkillPoints = skills.SkillPoints;

            await _dbContext.SaveChangesAsync();
        }

        public async void AddInventoryItem(InventoryItem item, Guid characterGuid)
        {
            var character = await _dbContext.Characters
                .Include(c => c.Inventory)
                .FirstOrDefaultAsync(c => c.Guid == characterGuid);
            if (character != null)
            {
                character.Inventory.Add(item);
                await _dbContext.SaveChangesAsync();
                await Clients.All.SendAsync("ReceiveEvent", $"{item.Name} added to {character.Name}'s inventory");
            }
        }
        public async void RemoveInventoryItem(InventoryItem item, Guid characterGuid)
        {
            var character = await _dbContext.Characters
                .Include(c => c.Inventory)
                .FirstOrDefaultAsync(c => c.Guid == characterGuid);
            if (character != null)
            {
                character.Inventory.Remove(item);
                await _dbContext.SaveChangesAsync();
                await Clients.All.SendAsync("ReceiveEvent", $"{item.Name} removed from {character.Name}'s inventory");
            }
        }
        public async void UpdateInventoryItem(InventoryItem item, Guid characterGuid)
        {
            var character = await _dbContext.Characters
                .Include(c => c.Inventory)
                .FirstOrDefaultAsync(c => c.Guid == characterGuid);
            if (character != null)
            {
                var existingItem = character.Inventory.FirstOrDefault(i => i.Id == item.Id);
                if (existingItem != null)
                {
                    existingItem.Name = item.Name;
                    existingItem.Description = item.Description;
                    //existingItem.Quantity = item.Quantity;
                    await _dbContext.SaveChangesAsync();
                    await Clients.All.SendAsync("ReceiveEvent", $"{item.Name} updated in {character.Name}'s inventory");
                }
            }
        }

        public async Task<IEnumerable<Character>> GetCharacters(Guid clientGuid)
        {
            var data = await _dbContext.Characters.Where(x=> x.CreatedBy == clientGuid)
                                        .Include(c => c.Race).Include(c => c.Stats)
                                        .Include(c => c.Class)
                                        .Include(c => c.Skills)
                                        .OrderBy(m => m.Id)
                                        .ToListAsync();
            return data;
        } 

    }
}
