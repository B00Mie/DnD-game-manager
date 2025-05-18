using Common.Enums;
using Common.Factories;
using GMHelper.Converters;
using System.Text.Json.Serialization;

namespace Common.Base
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(RaceJsonConverter))]
        public Race Race { get; set; }
        public CharacterClass Class { get; set; }
        public int Level { get; set; } = 1;

        public CharacterSkills CharacterSkills { get; set; } = new CharacterSkills();


        public List<InventoryItem> Inventory { get; set; } = new List<InventoryItem>();

        public Character()
        {
        }

        public Character(string name, string raceName, string @class, int level)
        {
            RaceEnum raceEnum = (RaceEnum)Enum.Parse(typeof(RaceEnum), raceName);

            Name = name;
            Class = new CharacterClass(@class);
            Race = RaceFactory.CreateRace(raceEnum);
            Level = level;
            CharacterSkills = SkillsFactory.CreateSkillsByRace(raceEnum);

        }

        public Character(string name, RaceEnum race, string charClass)
        {
            Name = name;
            Race = RaceFactory.CreateRace(race);
            Class = new CharacterClass(charClass);
            CharacterSkills = SkillsFactory.CreateSkillsByRace(race);

        }

        public void LevelUp()
        {
            //Race.LevelUp();
            CharacterSkills.SkillPoints += 1;
        }
    }
}
