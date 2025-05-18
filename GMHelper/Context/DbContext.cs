using Common.Base;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Context
{
    public sealed class DbContext
    {
        private static readonly Lazy<DbContext> _instance = new(() => new DbContext());
        public static DbContext Instance => _instance.Value;

        private readonly LiteDatabase _database;
        public string ConnectionString { get; set; } = string.Empty;
        private DbContext()
        {
            _database = new LiteDatabase("Filename=database.db;Connection=shared");
        }

        public ILiteCollection<Character> Characters => _database.GetCollection<Character>("characters");
    }
}
