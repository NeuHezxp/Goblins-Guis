using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/*
 * Allow user to pick stats?
 * Player Character (class maybe?)
 */
namespace Goblins_Guis.Character
{
    internal class Character : ICharacter //abstract class says every kind of this class implementation is unique.
    //Use inheritance
    {
        //enum for class
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


        public Character() // Constructor
        {
            // Initializing properties to default values
            Name = "Name";
            Class = CharacterClass.Warrior;
            HP = 100; // Default HP
            STR = 5; // Default Strength
            DEX = 5; // Default Dexterity
            CON = 5; // Default constitution
            INT = 5; // Default intelligence
            WIS = 5; // Default wisdom
            CHA = 5; // Default charisma
     
        }
        //private void notifyPropertyChanged([CallerMemberName]String propertyName = "")
        //{
        //    PropertyChanged(this, new PropertyChangedEventArgs());
        //}

      //  public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void attack() { }


        public virtual void defend(int incomingDamage) { }
    }


}
