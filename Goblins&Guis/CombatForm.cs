using Goblins_Guis.Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goblins_Guis
{

    public partial class CombatForm : Form
    {
        private Player player;
        private Enemy enemy;
        private CombatController combatController;
        public event Action CombatEnded;



        internal CombatForm(Player player, Enemy enemy)
        {
            InitializeComponent();
            this.player = player;
            this.enemy = enemy;

            player.HealthChanged += UpdatePlayerHealthBar;
            enemy.HealthChanged += UpdateEnemyHealthBar;

            // Initialize health progress bars
            healthProgressBar.Maximum = 100;
            enemyHealthProgressBar.Maximum = 100;
            UpdatePlayerHealthBar(player.HP);
            UpdateEnemyHealthBar(enemy.HP);

            combatController = new CombatController(player, enemy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void attackButton_Click(object sender, EventArgs e)
        {


        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Raise the event when the form is closing
            CombatEnded?.Invoke();
            player.HealthChanged -= UpdatePlayerHealthBar; // Unsubscribe from the event
            enemy.HealthChanged -= UpdateEnemyHealthBar; // Unsubscribe from the event
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckPlayerHealth();
            string message = combatController.PlayerAttack();
            MessageBox.Show(message);
            if (combatController.EnemyDead())
            {
                player.LevelUp();
                OnCombatEnded();
            }
        }
        private void stakeButton_Click(object sender, EventArgs e)
        {
            CheckPlayerHealth();
            string message = combatController.PlayerStakeAttack();
            if (combatController.EnemyDead())
            {
                player.LevelUp();
                OnCombatEnded();
            }
            MessageBox.Show(message);
        }

        private void Defendbutton_Click(object sender, EventArgs e)
        {
            CheckPlayerHealth();
            string message = combatController.PlayerDefend();
            MessageBox.Show(message);

        }
        private void UpdatePlayerHealthBar(int newHealth)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdatePlayerHealthBar), newHealth);
            }
            else
            {
                healthProgressBar.Value = Math.Clamp(newHealth, healthProgressBar.Minimum, healthProgressBar.Maximum);
            }
        }
        private void UpdateEnemyHealthBar(int newHealth)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateEnemyHealthBar), newHealth);
            }
            else
            {
                enemyHealthProgressBar.Value = Math.Clamp(newHealth, enemyHealthProgressBar.Minimum, enemyHealthProgressBar.Maximum);
            }
        }

        private void CombatForm_Load(object sender, EventArgs e)
        {

        }
        private void OnCombatEnded()
        {
            // Reset health for both player and enemy
            player.HP += 100;
            enemy.HP = 100;

            MessageBox.Show("Combat has ended!");
            // Handle additional cleanup or transitions here
            CombatEnded?.Invoke();
            this.Close();
        }
        private void CheckPlayerHealth()
        {
            if (combatController.PlayerDead())
            {
                MessageBox.Show("You have been defeated!");
                Application.Exit(); // This will close the application
            }
        }



    }
}
