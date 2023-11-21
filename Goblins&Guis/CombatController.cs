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
            //todo take health away from enemy
        }

        public void PerformDefend(int incomingDamage)
        {
            int damageMitigated = player.CalculateDefense(incomingDamage);
            int netDamage = incomingDamage - damageMitigated;

            
            player.HP -= netDamage; 
        }

        // TODO add enemy logic
    }
}

