using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Races
{
    internal class Khajiit : Race
    {
        public Khajiit() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.DirtyBlood.ToString();

            Stats = new Stats(1, 4, 1, 1);
            BasicStats = new Stats(1, 4, 1, 1);
            Id = 5;
        }
        public void LevelUp()
        {
            Stats.Strength += 1;
            Stats.Intelligence += 1;
            Stats.Agility += 4;
            Stats.Utility += 1;

        }
    }
}
