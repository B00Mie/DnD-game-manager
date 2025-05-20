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
            NameRu = "Каджит";
            TypeRu = "Грязнокровка";
        }
    }
}
