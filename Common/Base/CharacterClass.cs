namespace Common.Base
{
    public class CharacterClass
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; } = "";
        
        public CharacterClass(string name) {
            Name = name;
        }

    }
}
