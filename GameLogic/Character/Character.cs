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
namespace GameLogic
{
    public class Character : ICharacter , INotifyPropertyChanged //abstract class says every kind of this class implementation is unique.
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
        private string name;
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }
        private string gender;
        public string Gender
        {
            get => gender;
            set { gender = value; OnPropertyChanged(nameof(Gender)); }
        }
        private CharacterClass characterClass;
        public CharacterClass Class
        {
            get => characterClass;
            set
            {
                if (characterClass != value)
                {
                    characterClass = value;
                    OnPropertyChanged(nameof(Class));
                }
            }
        }
        private int hp;
        public int HP
        {
            get => hp;
            set
            {
                if (hp != value)
                {
                    hp = value;
                    OnPropertyChanged(nameof(HP));
                }
            }
        }

        private int strength;
        public int STR
        {
            get => strength;
            set
            {
                if (strength != value)
                {
                    strength = value;
                    OnPropertyChanged(nameof(STR));
                }
            }
        }

        private int dexterity;
        public int DEX
        {
            get => dexterity;
            set
            {
                if (dexterity != value)
                {
                    dexterity = value;
                    OnPropertyChanged(nameof(STR));
                }
            }
        }
        private int constitution;
        public int CON
        {
            get => constitution;
            set
            {
                if (constitution != value)
                {
                    constitution = value;
                    OnPropertyChanged(nameof(CON));
                }
            }
        }

        private int intelligence;
        public int INT
        {
            get => intelligence;
            set
            {
                if (intelligence != value)
                {
                    intelligence = value;
                    OnPropertyChanged(nameof(INT));
                }
            }
        }

        private int wisdom;
        public int WIS
        {
            get => wisdom;
            set
            {
                if (wisdom != value)
                {
                    wisdom = value;
                    OnPropertyChanged(nameof(WIS));
                }
            }
        }

        private int charisma;
        public int CHA
        {
            get => charisma;
            set
            {
                if (charisma != value)
                {
                    charisma = value;
                    OnPropertyChanged(nameof(CHA));
                }
            }
        }

        private int experience;
        public int EXP
        {
            get => experience;
            set
            {
                if (experience != value)
                {
                    experience = value;
                    OnPropertyChanged(nameof(EXP));
                }
            }
        }

        private int level;
        public int Level
        {
            get => level;
            set
            {
                if (level != value)
                {
                    level = value;
                    OnPropertyChanged(nameof(Level));
                }
            }
        }

        private int gold;
        public int Gold
        {
            get => gold;
            set
            {
                if (gold != value)
                {
                    gold = value;
                    OnPropertyChanged(nameof(Gold));
                }
            }
        }


        public Character() // Constructor
        {
            // Initializing properties to default values
            Name = "";
            Class = CharacterClass.Warrior;
            HP = 100; // Default HP
            STR = 5; // Default Strength
            DEX = 5; // Default Dexterity
            CON = 5; // Default constitution
            INT = 5; // Default intelligence
            WIS = 5; // Default wisdom
            CHA = 5; // Default charisma

        }

        // The implementation of OnPropertyChanged and the PropertyChanged event
    protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void attack() { }


        public virtual void defend(int incomingDamage) { }
    }


}
