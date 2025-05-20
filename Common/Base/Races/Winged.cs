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
            NameRu = "Крылатый";
            TypeRu = "Чистокровный";
        }
    }
}
