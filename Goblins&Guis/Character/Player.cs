using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis.Character
{
    internal class Player : Character, IAttack
    {
        public event Action<int> HealthChanged;
        private Random rand = new Random();
        
        public Player() : base()
        {
            HP = 100;
        }
        // Modify the HP property to trigger the event
        private int _hp;
        public int HP
        {
            get => _hp;
            set
            {
                int newHP = Math.Max(0, value); // Ensure health doesn't go below 0
                if (_hp != newHP)
                {
                    _hp = newHP;
                    HealthChanged?.Invoke(_hp); // Raise event
                }
            }
        }
        public int CalculateAttackDamage()
        {
            int baseDamage = 10; // Starting base damage

            // Class-based damage modifier
            int classDamageBonus = Class switch
            {
                CharacterClass.Warrior => STR * 2, // Warriors get double strength bonus
                CharacterClass.Mage => INT * 2,    // Mages get double intelligence bonus
                CharacterClass.Archer => DEX * 2,  // Archers get double dexterity bonus
            };

            // Random factor for variability
            int randomFactor = rand.Next(-5, 6); // Random number between -5 and 5

            // Calculate total damage
            int totalDamage = baseDamage + classDamageBonus + randomFactor;

            return Math.Max(1, totalDamage); // Ensure that damage is at least 1
        }
        public int CalculateDefense(int incomingDamage)
        {
            // Base defense value 
            int baseDefense = CON;

            // Class-specific defense modifier
            int defenseModifier = Class switch
            {
                CharacterClass.Warrior => CON * 2, 
                CharacterClass.Mage => WIS * 2,    
                CharacterClass.Archer => DEX * 2,  
            };

            int randomFactor = rand.Next(-2, 3);

            // Calculate total defense
            int totalDefense = baseDefense + defenseModifier + randomFactor;

            // Calculate damage mitigated
            int Guarded = Math.Min(totalDefense, incomingDamage);

            return Guarded;
        }

        // Player-specific methods here
        public bool stake(int stake)
        {
            //stake a dice roll and if fails take double damage but if succeed deal double damage
            return false;
        }

        public void Attack(int Roll)
        {
        }

        public bool attemptAttack(int difficulty)
        {
            return false;
        }
    }
}

