using Common.Base;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common.Races
{
    public class WoodElf : Race
    {
        public WoodElf() 
        {
            Name = GetType().Name;
            Type = RaceTypeEnum.CleanBlood.ToString();
            BaseHP = 250;

            Stats = new Stats(3, 3, 1, 2);
            BasicStats = new Stats(3, 3, 1, 2);
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
