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
            NameRu = "Орк";
            TypeRu = "Чистокровный";
        }
    }
}
