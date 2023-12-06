using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameLogic
{
    public class Enemy : Character
    {
        // Enemy Class Properties
        public int DifficultyLevel { get; set; }
        private Random rand = new Random();
        public event Action<int> HealthChanged;
        public int MaxHP { get; private set; } = 100; // Default max HP for enemy

        public Enemy() : base()
        {

            DifficultyLevel = 1; // Default difficulty
            HP = MaxHP;
        }
        private int _hp;
        public int HP
        {
            get => _hp;
            set
            {
                int newHP = Math.Max(0, value); // Ensures health doesn't go below 0
                if (_hp != newHP)
                {
                    _hp = newHP;
                    HealthChanged?.Invoke(_hp); // Raise event
                }
            }
        }
        public bool AttemptAttack()
        {
            int roll = rand.Next(1, 7);
            if (DifficultyLevel == 1)
            {
                return roll > 4;
            }else {
                return roll > 3;
            }
        }
        public int CalculateAttackDamage()
        {
            int baseDamage = 10;
            int attackBonus = STR * 2;
            int randomFactor = rand.Next(-5, 6);

            int totalDamage = baseDamage + attackBonus + randomFactor;
            return Math.Max(1, totalDamage);
        }
        public int CalculateDefense(int incomingDamage)
        {
            int baseDefense = CON;
            int defenseBonus = CON * 2;
            int randomFactor = rand.Next(-2, 3);

            int totalDefense = baseDefense + defenseBonus + randomFactor;
            int damageMitigated = Math.Min(totalDefense, incomingDamage);

            return damageMitigated;
        }

        public bool stake(int stake)
        {
            throw new NotImplementedException();
        }


    }
}
