using Common.SkillsImplementation;

namespace Common.Base
{

    public class Race
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public string NameRu { get; set; }
        public string Type { get; set; }
        public string TypeRu { get; set; }
        public int BaseHP { get; set; } = 200;

        public BasicStats BasicStats { get; set; } = null;

        public Race() { }

        public Race ToBase()
        {
            return new Race
            {
                Id = Id,
                Name = Name,
                Type = Type,
                BaseHP = BaseHP,
                NameRu = NameRu,
                TypeRu = TypeRu,

                BasicStats = BasicStats
            };
        }
    }
}
