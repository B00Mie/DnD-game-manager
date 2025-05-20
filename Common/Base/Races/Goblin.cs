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
            NameRu = "Гоблин";
            TypeRu = "Грязнокровка";
        }
    }
}
