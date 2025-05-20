using Common.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Server.Database;
using Server.Models;

namespace Server.Services
{
    public class CharacterService
    {
        private readonly IDbContextFactory<MainDbContext> _dbFactory;
        public event Action<Message>? MessageAdded;

        public CharacterService(IDbContextFactory<MainDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Character>> GetAllAsync()
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Characters
                           .Include(c => c.Race)
                           .OrderBy(m => m.Id)
                           .ToListAsync();
        }

        public async Task<Race> GetRaceById(int id)
        {
            await using var db = _dbFactory.CreateDbContext();
            var race = await db.Races
                                     .FirstOrDefaultAsync(c => c.Id == id);
            return race;
        }

        public async Task<Character> GetById(int id)
        {
            await using var db = _dbFactory.CreateDbContext();
            var character = await db.Characters
                                     .FirstOrDefaultAsync(c => c.Id == id);
            return character;
        }
    }
}
