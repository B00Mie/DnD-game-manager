using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Races
{
    public class Winged : Race
    {
        public Winged() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.CleanBlood.ToString();
            BaseHP = 250;

            Stats = new Stats(2, 2, 3, 2);
            BasicStats = new Stats(2, 2, 3, 2);
        }
        public void LevelUp()
        {
            Stats.Strength += 1;
            Stats.Intelligence += 3;
            Stats.Agility += 2;
            Stats.Utility += 1;
        }
    }
}
