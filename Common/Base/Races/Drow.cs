using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Races
{
    internal class Drow : Race
    {
        public Drow() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.CleanBlood.ToString();

            BaseHP = 250;
            Stats = new Stats(2, 3, 3, 2);
            BasicStats = new Stats(2, 3, 3, 2);
            Id = 1;
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
