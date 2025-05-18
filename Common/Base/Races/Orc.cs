using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Races
{
    public class Orc :Race
    {
        public Orc() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.CleanBlood.ToString();

            BaseHP = 300;
            Stats = new Stats(5, 1, 1, 3);
            BasicStats = new Stats(5, 1, 1, 3);
        }
        public void LevelUp()
        {
            Stats.Strength += 4;
            Stats.Intelligence += 1;
            Stats.Agility += 1;
            Stats.Utility += 1;
        }
    }
}
