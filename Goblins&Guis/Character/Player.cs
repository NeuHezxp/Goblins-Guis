using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis.Character
{
    internal class Player : Character, IAttack, IDefend
    {

        private Random rand = new Random();
        public Player() : base()
        {

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
        public void Defend(int incomingDamage)
        {
            //defend based on class and a random number
            //defend based on stats
        }

        // Player-specific methods here
        public bool stake(int stake)
        {
            //stake a dice roll and if fails take double damage but if succeed deal double damage
            return false;
        }

        public void Attack(int Roll)
        {
            //attack with random number 1-6
            //attack with stats
            //attack modified by class
            //
        }

        public bool attemptAttack(int difficulty)
        {


            return true;
        }


    }
}

