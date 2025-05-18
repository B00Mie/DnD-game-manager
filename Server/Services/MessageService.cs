using Common.Base;
using Microsoft.EntityFrameworkCore;
using Server.Database;
using Server.Models;
using System;

namespace Server.Services
{
    public class MessageService
    {
        private readonly IDbContextFactory<MainDbContext> _dbFactory;
        public event Action<Message>? MessageAdded;

        public MessageService(IDbContextFactory<MainDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Message>> GetAllAsync()
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Messages
                           .OrderBy(m => m.SentAt)
                           .ToListAsync();
        }

        public async Task<List<Character>> GetCharacters()
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Characters
                           .OrderBy(m => m.Id)
                           .ToListAsync();
        }

        public async Task AddAsync(string user, string text)
        {
            var msg = new Message
            {
                User = user,
                Text = text,
                SentAt = DateTime.UtcNow
            };

            await using (var db = _dbFactory.CreateDbContext())
            {
                db.Messages.Add(msg);
                await db.SaveChangesAsync();
            }

            MessageAdded?.Invoke(msg);
        }
    }
}
