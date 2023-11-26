using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Goblins_Guis.Character
{
    internal class Enemy : Character, IDefend, IAttack
    {
        // Enemy-specific properties, like AI difficulty level
        public int DifficultyLevel { get; set; }
        private Random rand = new Random();
        public event Action<int> HealthChanged;

        public Enemy() : base()
        {

            DifficultyLevel = 1; // Default difficulty
            HP = 100;
        }
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
            // Simple AI for determining attack damage
            // You can make this more complex based on DifficultyLevel
            int baseDamage = 10;
            int attackBonus = STR * 2;
            int randomFactor = rand.Next(-5, 6);

            int totalDamage = baseDamage + attackBonus + randomFactor;
            return Math.Max(1, totalDamage);
        }
        public int CalculateDefense(int incomingDamage)
        {
            // Simple AI for determining defense
            // You can make this more complex based on DifficultyLevel
            int baseDefense = CON;
            int defenseBonus = CON * 2;
            int randomFactor = rand.Next(-2, 3);

            int totalDefense = baseDefense + defenseBonus + randomFactor;
            int damageMitigated = Math.Min(totalDefense, incomingDamage);

            return damageMitigated;
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
