using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Allow user to pick stats?
 * Player Character (class maybe?)
 * Items
 */
namespace Goblins_Guis
{
    internal abstract class Character
    //Use inheritance
    {
        // Define the CharacterClass as an enum for better type safety
        public enum CharacterClass
        {
            Warrior,
            Mage,
            Archer
        }
        //general characteristics of the character
        // Auto-implemented properties for encapsulation
        public string Name { get; set; }
        public string Gender { get; set; }
        public CharacterClass Class { get; set; }
        public int HP { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON { get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        public int EXP { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }

        // Constructor
        public Character()
        {
            // Initializing properties to default values
            Name = "Name";
            Class = CharacterClass.Warrior; // Default class
            HP = 100; // Default HP
            STR = 5; // Default Strength
            DEX = 5; // Default Dexterity
            CON = 5; // Default constitution
            INT = 5; // Default intelligence
            WIS = 5; // Default wisdom
            CHA = 5; // Default charisma
            EXP = 0; // Default experience
            Level = 1; // Default level
            Gold = 0; // Default gold
        }
        public virtual void attack() { }
    }

}
