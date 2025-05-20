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
            NameRu = "Тёмный эльф";
            TypeRu = "Чистокровный";
        }
        
    }
}
