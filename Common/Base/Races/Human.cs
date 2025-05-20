using Common.SkillsImplementation;
using Common.Base;
using Common.Enums;
using Common.Factories;

namespace Common.Races
{
    public class Human :Race
    {
        public Human() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.CleanBlood.ToString();
            NameRu = "Человек";
            TypeRu = "Чистокровный";
        }
    }
}
