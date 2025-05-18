using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Races
{
    public class Dwarf : Race
    {
        public Dwarf() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.DirtyBlood.ToString();

            BaseHP = 350;
            Stats = new Stats(2, 1, 1, 3);
            BasicStats = new Stats(2, 1, 1, 3);
            Id = 2;
        }

        public void LevelUp()
        {
            Stats.Strength += 3;
            Stats.Intelligence += 1;
            Stats.Agility += 1;
            Stats.Utility += 3;
        }
    }
}
