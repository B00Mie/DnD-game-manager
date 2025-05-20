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
        public int RaceId { get; set; } = 0;
        public int Level { get; set; } = 1;
        public int BaseHP { get; set; } = 200;

        public CharacterClass Class { get; set; }
        public Stats Stats { get; set; }
        public CharacterSkills CharacterSkills { get; set; } = new CharacterSkills();
        //[JsonConverter(typeof(RaceJsonConverter))]
        public Race Race { get; set; }


        public List<InventoryItem> Inventory { get; set; } = new List<InventoryItem>();

        public Character()
        {
        }

        public Character(string name, string raceName, string @class, int level)
        {
            RaceEnum raceEnum = (RaceEnum)Enum.Parse(typeof(RaceEnum), raceName);
            RaceId = (int)raceEnum;
            Name = name;
            Class = new CharacterClass(@class);
            Race = RaceFactory.CreateRace(raceEnum);
            Level = level;
            CharacterSkills = SkillsFactory.CreateSkillsByRace(raceEnum);

            Stats = Race.BasicStats.ToStats();
            BaseHP = Race.BaseHP;

        }

        public Character(string name, RaceEnum race, string charClass)
        {
            Name = name;
            Race = RaceFactory.CreateRace(race);
            RaceId = (int) race;
            Class = new CharacterClass(charClass);
            CharacterSkills = SkillsFactory.CreateSkillsByRace(race);
            Stats = Race.BasicStats.ToStats();
            BaseHP = Race.BaseHP;

        }
        public void LevelUp()
        {
            switch (Name)
            {
                case "Human":
                    Stats.Strength += 1;
                    Stats.Intelligence += 2;
                    Stats.Agility += 2;
                    Stats.Utility += 2;
                    break;
                case "Dwarf":
                    Stats.Strength += 3;
                    Stats.Intelligence += 1;
                    Stats.Agility += 1;
                    Stats.Utility += 3;
                    break;
                case "Orc":
                    Stats.Strength += 4;
                    Stats.Intelligence += 1;
                    Stats.Agility += 1;
                    Stats.Utility += 1;
                    break;
                case "Khajiit":
                    Stats.Strength += 1;
                    Stats.Intelligence += 1;
                    Stats.Agility += 4;
                    Stats.Utility += 1;
                    break;
                case "Underwater":
                    Stats.Strength += 2;
                    Stats.Intelligence += 3;
                    Stats.Agility += 1;
                    Stats.Utility += 1;
                    break;
                case "Drow":
                    Stats.Strength += 1;
                    Stats.Intelligence += 2;
                    Stats.Agility += 2;
                    Stats.Utility += 2;
                    break;
                case "WoodElf":
                    Stats.Strength += 1;
                    Stats.Intelligence += 3;
                    Stats.Agility += 2;
                    Stats.Utility += 1;
                    break;
                case "Winged":
                    Stats.Strength += 1;
                    Stats.Intelligence += 3;
                    Stats.Agility += 2;
                    Stats.Utility += 1;
                    break;
                case "Goblin":
                    Stats.Strength += 1;
                    Stats.Intelligence += 1;
                    Stats.Agility += 3;
                    Stats.Utility += 3;
                    break;
                default:
                    Stats.Strength += 1;
                    Stats.Intelligence += 2;
                    Stats.Agility += 2;
                    Stats.Utility += 2;
                    break;
            }
            CharacterSkills.SkillPoints += 1;
        }


    }
}
