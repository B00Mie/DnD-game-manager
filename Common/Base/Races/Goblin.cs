using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Races
{
    internal class Goblin : Race
    {
        public Goblin() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.DirtyBlood.ToString();

            BaseHP = 150;
            Stats = new Stats(1, 2, 3, 3);
            BasicStats = new Stats(1, 2, 3, 3);
            Id = 3;
        }
        public void LevelUp()
        {
            Stats.Strength += 1;
            Stats.Intelligence += 1;
            Stats.Agility += 3;
            Stats.Utility += 3;
        }
    }
}
