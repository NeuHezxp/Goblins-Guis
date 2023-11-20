using Goblins_Guis.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis
{
    internal class CombatController
    {
        private Player player;
        private Enemy enemy;
        // If you have enemy characters or other combat participants, include them here

        public CombatController(Player player)
        {
            this.player = player;
            this.enemy = new Enemy();
        }

        public void PerformAttack()
        {
            int damage = player.CalculateAttackDamage();
            // Additional logic to apply this damage to the enemy
        }

        public void PerformPlayerDefend(int incomingDamage)
        {
            player.Defend(incomingDamage);

            // Additional logic for defense outcome
        }

        // Additional methods for handling other combat actions
    }
}

