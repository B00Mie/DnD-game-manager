using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Races
{
    internal class Underwater : Race
    {
        public Underwater() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.CleanBlood.ToString();

            Stats = new Stats(3, 1, 2, 1);
            BasicStats = new Stats(3, 1, 2, 1);
            BaseHP = 325;
        }
        public void LevelUp()
        {
            Stats.Strength += 2;
            Stats.Intelligence += 3;
            Stats.Agility += 1;
            Stats.Utility += 1;
        }
    }
}
