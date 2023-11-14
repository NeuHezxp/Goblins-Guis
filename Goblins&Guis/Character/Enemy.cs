using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis.Character
{
    internal class Enemy : Character, IDefend, IAttack
    {
        // Enemy-specific properties, like AI difficulty level
        public int DifficultyLevel { get; set; }

        public Enemy() : base()
        {

            DifficultyLevel = 1; // Default difficulty
        }

        public void Defend(int incomingDamage)
        {
            throw new NotImplementedException();
        }

        public bool attemptAttack(int difficulty)
        {
            throw new NotImplementedException();
        }

        public bool stake(int stake)
        {
            throw new NotImplementedException();
        }

        public void Attack(int Roll)
        {
            throw new NotImplementedException();
        }

        // Enemy-specific methods here

    }
}
