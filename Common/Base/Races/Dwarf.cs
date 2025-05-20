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
            NameRu = "Гном";
            TypeRu = "Грязнокровка";
        }

    }
}
