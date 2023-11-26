using Goblins_Guis.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Goblins_Guis
{
    internal class CombatController
    {
        private Player player;
        private Enemy enemy;
        private Random rand = new Random();
        // If you have enemy characters or other combat participants, include them here

        public CombatController(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        //public void PerformAttack()
        //{
        //    int damage = player.CalculateAttackDamage();
        //    player.HP -= player.CalculateAttackDamage();
        //}
        public void PlayerAttack()
        {
            int damage = player.CalculateAttackDamage();
            // Apply damage to enemy
            enemy.HP -= damage;
            // Check for enemy defeat, other logic...

            // After player's turn, enemy gets a turn
            EnemyTurn();
        }
        public void PlayerDefend()
        {
            // Player's defend logic (if needed)
            // Prepare for enemy's turn
            EnemyTurn();
        }

        //public void PerformDefend(int incomingDamage)
        //{
        //    int damageMitigated = player.CalculateDefense(incomingDamage);
        //    int netDamage = incomingDamage - damageMitigated;


        //    player.HP -= netDamage; 
        //}

        // TODO add enemy logic
        private void EnemyTurn()
        {
            // Decide whether the enemy will attack or defend
            if (rand.NextDouble() > 0.5) // Random decision for simplicity
            {
                EnemyAttack();
            }
            else
            {
                EnemyDefend();
            }
        }
        private void EnemyAttack()
        {
            int damage = enemy.CalculateAttackDamage();
            // Apply damage to player
            player.HP -= damage;
            // Check for player defeat, other logic...
        }

        private void EnemyDefend()
        {
            // Enemy's defend logic (if needed)
        }
    }
}

