namespace GildedRose
{
    public class Character {
        private string Name;
        private string Gender;
        private int Level;
        private string SkillClass;
        private string Race;

        public Character(string name, string gender, int level, string skillClass, string race) {
            Name = name;
            Gender = gender;
            Level = level;
            SkillClass = skillClass;
            Race = race;
        }
    }
}