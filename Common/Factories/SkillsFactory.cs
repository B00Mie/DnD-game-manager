using Common.Base;
using Common.Enums;

namespace Common.Factories
{
    public static class SkillsFactory
    {
        public static CharacterSkills CreateSkillsByRace(RaceEnum race)
        {
            return new CharacterSkills
            {
                GenerallSkills = CreateGeneralSkillsByRace(race),
                MagicSkills = CreateMagicSkillsByRace(race),
                WeaponSkills = CreateWeaponSkillsByRace(race)
            };
        }

        private static SkillGroup CreateGeneralSkillsByRace(RaceEnum race)
        {
            SkillGroup skillGroup = new SkillGroup
            {
                GroupName = "General",
                Skills = race switch
                {
                    RaceEnum.Human => new List<Skill>
                        {
                            new() { Name = "Diplomacy", Level = 1 },
                            new() { Name = "Leadership", Level = 1 }
                        },
                    RaceEnum.Drow => new List<Skill>
                        {
                            new() { Name = "Stealth", Level = 1 },
                            new() { Name = "Darkvision", Level = 1 }
                        },
                    RaceEnum.Goblin => new List<Skill>
                        {
                            new() { Name = "Sneak", Level = 1 },
                            new() { Name = "Trap Setting", Level = 1 }
                        },
                    RaceEnum.Khajiit => new List<Skill>
                        {
                            new() { Name = "Claw Attack", Level = 1 },
                            new() { Name = "Night Vision", Level = 1 }
                        },
                    RaceEnum.Underwater => new List<Skill>
                        {
                            new() { Name = "Swim", Level = 1 },
                            new() { Name = "Water Breathing", Level = 1 }
                        },
                    RaceEnum.Winged => new List<Skill>
                        {
                            new() { Name = "Fly", Level = 1 },
                            new() { Name = "Aerial Combat", Level = 1 }
                        },
                    RaceEnum.WoodElf => new List<Skill>
                        {
                            new() { Name = "Archery", Level = 1 },
                            new() { Name = "Nature Lore", Level = 1 }
                        },
                    RaceEnum.Orc => new List<Skill>
                        {
                            new() { Name = "Berserk", Level = 1 },
                            new() { Name = "Intimidation", Level = 1 }
                        },
                    RaceEnum.Dwarf => new List<Skill>
                        {
                            new() { Name = "Stonecunning", Level = 1 },
                            new() { Name = "Craftsmanship", Level = 1 }
                        },
                    _ => throw new NotImplementedException(),
                }
            };
            return skillGroup;
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
                            new() { Name = "Diplomacy", Level = 1 },
                            new() { Name = "Leadership", Level = 1 }
                        },
                    RaceEnum.Drow => new List<Skill>
                        {
                            new() { Name = "Stealth", Level = 1 },
                            new() { Name = "Darkvision", Level = 1 }
                        },
                    RaceEnum.Goblin => new List<Skill>
                        {
                            new() { Name = "Sneak", Level = 1 },
                            new() { Name = "Trap Setting", Level = 1 }
                        },
                    RaceEnum.Khajiit => new List<Skill>
                        {
                            new() { Name = "Claw Attack", Level = 1 },
                            new() { Name = "Night Vision", Level = 1 }
                        },
                    RaceEnum.Underwater => new List<Skill>
                        {
                            new() { Name = "Swim", Level = 1 },
                            new() { Name = "Water Breathing", Level = 1 }
                        },
                    RaceEnum.Winged => new List<Skill>
                        {
                            new() { Name = "Fly", Level = 1 },
                            new() { Name = "Aerial Combat", Level = 1 }
                        },
                    RaceEnum.WoodElf => new List<Skill>
                        {
                            new() { Name = "Archery", Level = 1 },
                            new() { Name = "Nature Lore", Level = 1 }
                        },
                    RaceEnum.Orc => new List<Skill>
                        {
                            new() { Name = "Berserk", Level = 1 },
                            new() { Name = "Intimidation", Level = 1 }
                        },
                    RaceEnum.Dwarf => new List<Skill>
                        {
                            new() { Name = "Stonecunning", Level = 1 },
                            new() { Name = "Craftsmanship", Level = 1 }
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
                            new() { Name = "Diplomacy", Level = 1 },
                            new() { Name = "Leadership", Level = 1 }
                        },
                    RaceEnum.Drow => new List<Skill>
                        {
                            new() { Name = "Stealth", Level = 1 },
                            new() { Name = "Darkvision", Level = 1 }
                        },
                    RaceEnum.Goblin => new List<Skill>
                        {
                            new() { Name = "Sneak", Level = 1 },
                            new() { Name = "Trap Setting", Level = 1 }
                        },
                    RaceEnum.Khajiit => new List<Skill>
                        {
                            new() { Name = "Dagger", Level = 1 },
                            new() { Name = "Bow", Level = 1 }
                        },
                    RaceEnum.Underwater => new List<Skill>
                        {
                            new() { Name = "Swim", Level = 1 },
                            new() { Name = "Water Breathing", Level = 1 }
                        },
                    RaceEnum.Winged => new List<Skill>
                        {
                            new() { Name = "Fly", Level = 1 },
                            new() { Name = "Aerial Combat", Level = 1 }
                        },
                    RaceEnum.WoodElf => new List<Skill>
                        {
                            new() { Name = "Archery", Level = 1 },
                            new() { Name = "Nature Lore", Level = 1 }
                        },
                    RaceEnum.Orc => new List<Skill>
                        {
                            new() { Name = "Berserk", Level = 1 },
                            new() { Name = "Intimidation", Level = 1 }
                        },
                    RaceEnum.Dwarf => new List<Skill>
                        {
                            new() { Name = "Mace", Level = 1 },
                            new() { Name = "Axe", Level = 1 }
                        },
                    _ => throw new NotImplementedException(),
                }
            };
            return skillGroup;
        }
    }

}
