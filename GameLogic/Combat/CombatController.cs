
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameLogic
{
    internal class CombatController
    {
        private Player player;
        private Enemy enemy;
        private Random rand = new Random();
        

        public CombatController(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }
        public string PlayerAttack()
        {
            if (player.AttemptAttack())
            {
                int damage = player.CalculateAttackDamage();
                enemy.HP -= damage;
                string enemyTurnResult = EnemyTurn();
                return $"{player.Name} attacked the enemy dealing {damage} damage.\n{enemyTurnResult}";
            }
            else
            {
                string enemyTurnResult = EnemyTurn(); 
                return $"{player.Name} attempted to attack the enemy but missed.\n{enemyTurnResult}";
            }

            
        }
        public void ResolveCombat()
        {
            if (EnemyDead())
            {
                player.LevelUp();
            }
        }
        public string PlayerStakeAttack()
        {
            int roll = rand.Next(1, 7); // Roll a die (1-6)
            if (roll > 3) //4-6 is a hit
            {
                // Success: Deal double damage
                int damage = player.CalculateAttackDamage() * 2;
                enemy.HP -= damage;
                return $"{player.Name} successfully staked and dealt double damage of {damage}!";
            }
            else
            {
                // Failure: Take double damage
                int damage = enemy.CalculateAttackDamage() * 2;
                player.HP -= damage;
                return $"{player.Name} failed the stake and took double damage of {damage}!";
            }
        }
        public string PlayerDefend()
        {
            string enemyTurnResult = EnemyTurn(); // Get the enemy's action
            if (enemyTurnResult.StartsWith("Enemy attacked")) // Simple check to see if enemy attacked
            {
                int incomingDamage = enemy.CalculateAttackDamage();
                int mitigatedDamage = player.CalculateDefense(incomingDamage);
                player.HP -= (incomingDamage - mitigatedDamage); // Apply the reduced damage

                return $"Player defended. {enemyTurnResult} Mitigated {mitigatedDamage} damage.";
            }
            else
            {
                return $"Player defended. {enemyTurnResult}";
            }
        }
        // Enemy-specific methods here
        private string EnemyTurn()
        {
            double actionRoll = rand.NextDouble();

            if (actionRoll > 0.66) // 33% chance to attack
            {
                return EnemyAttack();
            }
            else if (actionRoll > 0.33) // 33% chance to defend
            {
                return EnemyDefend();
            }
            else // 33% chance to stake
            {
                return EnemyStakeAttack(); // Enemy Stakes action
            }
        }
        private string EnemyTaunt()
        {
            string[] taunts = { "The enemy mocks your skills!", "The enemy laughs at you!", "The enemy sneers at your efforts!" };
            string taunt = taunts[rand.Next(taunts.Length)];
            return taunt;
        }
        public string EnemyAttack()
        {
            if (enemy.AttemptAttack())
            {
                int damage = enemy.CalculateAttackDamage();
                player.HP -= damage;
                return $"Enemy attacked {player.Name} dealing {damage} damage.";
            }
            else
            {
                return "Enemy attempted to attack but missed.";
            }
        }
        public string EnemyStakeAttack()
        {
            int roll = rand.Next(1, 7); // Roll a "die" (1-6)
            if (roll > 3) //  4-6 is a success
            {
                int damage = enemy.CalculateAttackDamage() * 2;
                player.HP -= damage;
                return $"{enemy.Name} successfully staked and dealt double damage of {damage}!";
            }
            else
            {
                // Failure: Enemy takes double damage
                int damage = player.CalculateAttackDamage() * 2;
                enemy.HP -= damage;
                return $"{enemy.Name} failed the stake and took double damage of {damage}!";
            }
        }

        private string EnemyDefend()
        {
            return $"Enemy Defended {player.Name} Blocking damage.";
        }
        public bool EnemyDead()
        {
            return enemy.HP <= 0;
        }
        public bool PlayerDead()
        {
           return player.HP <= 0;
        }
    }
}

