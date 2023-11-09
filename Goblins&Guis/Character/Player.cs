using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis
{
    internal class Player : Character,IAttack,IDefend
    {
        

        public Player() : base()
        {
            
        }
        private void modifier()
        {

        }
         
        // Player-specific methods here
        public bool stake(int stake)
        {
            //stake a dice roll and if fails take double damage but if succeed deal double damage
           return false;
        }
        public void Defend(int incomingDamage) 
        {
            //defend based on class and a random number
            //defend based on stats
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

