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
            NameRu = "Лесной эльф";
            TypeRu = "Чистокровный";
        }
    }
}
