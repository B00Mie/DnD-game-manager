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
            var stats = CreateStatsByRace(race);
            Race? res = race switch
            {
                RaceEnum.Human => new Human(),
                RaceEnum.Dwarf => new Dwarf(),
                RaceEnum.Orc => new Orc(),
                RaceEnum.Khajiit => new Khajiit(),
                RaceEnum.Underwater => new Underwater(),
                RaceEnum.Drow => new Drow(),
                RaceEnum.WoodElf => new WoodElf(),
                RaceEnum.Winged => new Winged(),
                RaceEnum.Goblin => new Goblin(),
                _ => new Human(),
            };
            res.BasicStats = stats;
            res.Id = (int)race;
            return res;
        }

        public static Race CreateByName(string name)
        {
            return name switch
            {
                "Human" => new Human(),
                "Dwarf" => new Dwarf(),
                "Orc" => new Orc(),
                "Khajiit" => new Khajiit(),
                "Underwater" => new Underwater(),
                "Drow" => new Drow(),
                "WoodElf" => new WoodElf(),
                "Winged" => new Winged(),
                "Goblin" => new Goblin(),
                _ => new Human(),
            };
        }

        public static BasicStats CreateStatsByRace(RaceEnum race)
        {
            return race switch
            {
                RaceEnum.Drow => new BasicStats(2, 3, 3, 2),
                RaceEnum.Dwarf => new BasicStats(2, 1, 1, 3),
                RaceEnum.Goblin => new BasicStats(1, 2, 3, 3),
                RaceEnum.Human => new BasicStats(1, 1, 1, 1),
                RaceEnum.Khajiit => new BasicStats(1, 4, 1, 1),
                RaceEnum.Orc => new BasicStats(5, 1, 1, 3),
                RaceEnum.Underwater => new BasicStats(3, 1, 2, 1),
                RaceEnum.Winged => new BasicStats(2, 2, 3, 2),
                RaceEnum.WoodElf => new BasicStats(3, 3, 1, 2),
                _ => new BasicStats(1, 1, 1, 1),
            };
        }
    }
}
