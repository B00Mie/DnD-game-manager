using Common.SkillsImplementation;

namespace Common.Base
{

    public class Race
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Type { get; set; }

        public Stats Stats { get; set; }
        public Stats BasicStats { get; set; }
        

        public int BaseHP { get; set; } = 200;

        //public void LevelUp() { }

    }
}
