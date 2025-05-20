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
            BaseHP = 325;
            NameRu = "Глубоководный";
            TypeRu = "Чистокровный";
        }
    }
}
