using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis
{
    internal class Enemy : Character
    {
        // Enemy-specific properties, like AI difficulty level
        public int DifficultyLevel { get; set; }

        public Enemy() : base()
        {
            
            DifficultyLevel = 1; // Default difficulty
        }

        // Enemy-specific methods here
    public override void attack() { }
    }
}
