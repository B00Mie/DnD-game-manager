namespace Common.Base
{
    public class BasicStats
    {
        public int Strength { get; set; } = 0;
        public int Agility { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        public int Utility { get; set; } = 0;

        public BasicStats() { }
        public BasicStats(int str, int agi, int intel, int uti)
        {
            Strength = str;
            Agility = agi;
            Intelligence = intel;
            Utility = uti;
        }
        public Stats ToStats()
        {
            return new Stats(Strength, Agility, Intelligence, Utility);
        }
    }
}
