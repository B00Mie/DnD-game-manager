using CharacterManager.Base.redundant;
namespace Common.SkillsImplementation
{
    public class GeneralSkills : Skills
    {
        public GeneralSkills(Dictionary<string, int> skills) : base(skills)
        {
        }

        public int Stealth { get; set; }
        public int Perception { get; set; }
        public int Medicine { get; set; }
    }
}
