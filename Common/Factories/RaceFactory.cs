using Common.Base;
using Common.Enums;
using Common.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Factories
{
    public static class RaceFactory
    {
        public static Race CreateRace(RaceEnum race)
        {
            switch (race)
            {
                case RaceEnum.Human:
                    return new Human();
                case RaceEnum.Dwarf:
                    return new Dwarf();
                case RaceEnum.Orc:
                    return new Orc();
                case RaceEnum.Khajiit:
                    return new Khajiit();
                case RaceEnum.Underwater:
                    return new Underwater();
                case RaceEnum.Drow:
                    return new Drow();
                case RaceEnum.WoodElf:
                    return new WoodElf();
                case RaceEnum.Winged:
                    return new Winged();
                case RaceEnum.Goblin:
                    return new Goblin();
                default: return new Human();
            }
        }

        public static Race CreateByName(string name)
        {
            switch (name)
            {
                case "Human":
                    return new Human();
                case "Dwarf":
                    return new Dwarf();
                case "Orc":
                    return new Orc();
                case "Khajiit":
                    return new Khajiit();
                case "Underwater":
                    return new Underwater();
                case "Drow":
                    return new Drow();
                case "WoodElf":
                    return new WoodElf();
                case "Winged":
                    return new Winged();
                case "Goblin":
                    return new Goblin();
                default: return new Human();
            }
        }

    }
}
