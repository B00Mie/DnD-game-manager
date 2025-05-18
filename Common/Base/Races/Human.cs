using Common.SkillsImplementation;
using Common.Base;
using Common.Enums;

namespace Common.Races
{
    public class Human :Race
    {
        public Human() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.CleanBlood.ToString();

            Stats = new Stats(1, 1, 1, 1);
            BasicStats = new Stats(1, 1, 1, 1);
            Id = 4;

        }
        public void LevelUp()
        {
            Stats.Strength += 1;
            Stats.Intelligence += 2;
            Stats.Agility += 2;
            Stats.Utility += 2;
        }
    }
}
