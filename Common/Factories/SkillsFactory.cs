using Common.Base;
using Common.Base.Enums;
using Common.Enums;

namespace Common.Factories
{
    public static class SkillsFactory
    {
        public static List<Skill> CreateSkillsByRace(RaceEnum race)
        {
            var result = race switch
            {
                RaceEnum.Human => new List<Skill>
                        {
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.General},
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.Drow => new List<Skill>
                        {
                            new() { Name = "Stealth", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Darkvision", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.Goblin => new List<Skill>
                        {
                            new() { Name = "Sneak", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Trap Setting", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.Khajiit => new List<Skill>
                        {
                            new() { Name = "Claw Attack", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Night Vision", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.Underwater => new List<Skill>
                        {
                            new() { Name = "Swim", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Water Breathing", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.Winged => new List<Skill>
                        {
                            new() { Name = "Fly", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Aerial Combat", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.WoodElf => new List<Skill>
                        {
                            new() { Name = "Archery", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Nature Lore", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.Orc => new List<Skill>
                        {
                            new() { Name = "Berserk", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Intimidation", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                RaceEnum.Dwarf => new List<Skill>
                        {
                            new() { Name = "Stonecunning", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Craftsmanship", Level = 1, SkillGroup = SkillGroupEnum.General },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                _ => throw new NotImplementedException(),
            };
            return result;
        }

        private static SkillGroup CreateMagicSkillsByRace(RaceEnum race)
        {

            SkillGroup skillGroup = new SkillGroup
            {
                GroupName = "Magic",
                Skills = race switch
                {
                    RaceEnum.Human => new List<Skill>
                        {
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.Drow => new List<Skill>
                        {
                            new() { Name = "Stealth", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Darkvision", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.Goblin => new List<Skill>
                        {
                            new() { Name = "Sneak", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Trap Setting", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.Khajiit => new List<Skill>
                        {
                            new() { Name = "Claw Attack", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Night Vision", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.Underwater => new List<Skill>
                        {
                            new() { Name = "Swim", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Water Breathing", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.Winged => new List<Skill>
                        {
                            new() { Name = "Fly", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Aerial Combat", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.WoodElf => new List<Skill>
                        {
                            new() { Name = "Archery", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Nature Lore", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.Orc => new List<Skill>
                        {
                            new() { Name = "Berserk", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Intimidation", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    RaceEnum.Dwarf => new List<Skill>
                        {
                            new() { Name = "Stonecunning", Level = 1, SkillGroup = SkillGroupEnum.Magic },
                            new() { Name = "Craftsmanship", Level = 1, SkillGroup = SkillGroupEnum.Magic }
                        },
                    _ => throw new NotImplementedException(),
                }
            };
            return skillGroup;
        }

        private static SkillGroup CreateWeaponSkillsByRace(RaceEnum race)
        {

            SkillGroup skillGroup = new SkillGroup
            {
                GroupName = "Weapon",
                Skills = race switch
                {
                    RaceEnum.Human => new List<Skill>
                        {
                            new() { Name = "Diplomacy", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Leadership", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.Drow => new List<Skill>
                        {
                            new() { Name = "Stealth", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Darkvision", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.Goblin => new List<Skill>
                        {
                            new() { Name = "Sneak", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Trap Setting", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.Khajiit => new List<Skill>
                        {
                            new() { Name = "Dagger", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Bow", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.Underwater => new List<Skill>
                        {
                            new() { Name = "Swim", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Water Breathing", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.Winged => new List<Skill>
                        {
                            new() { Name = "Fly", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Aerial Combat", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.WoodElf => new List<Skill>
                        {
                            new() { Name = "Archery", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Nature Lore", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.Orc => new List<Skill>
                        {
                            new() { Name = "Berserk", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Intimidation", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    RaceEnum.Dwarf => new List<Skill>
                        {
                            new() { Name = "Mace", Level = 1, SkillGroup = SkillGroupEnum.Weapon },
                            new() { Name = "Axe", Level = 1, SkillGroup = SkillGroupEnum.Weapon }
                        },
                    _ => throw new NotImplementedException(),
                }
            };
            return skillGroup;
        }
    }

}
