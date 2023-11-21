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
        private CombatController combatController;
        public event Action CombatEnded;

        internal CombatForm(Player player)
        {
            InitializeComponent();
            this.player = player;

            combatController = new CombatController(player);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void attackButton_Click(object sender, EventArgs e)
        {
            combatController.PerformAttack();
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Raise the event when the form is closing
            CombatEnded?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            combatController.PerformAttack();
            //debug info for the attack
            int damage = player.CalculateAttackDamage();
            string name = player.Name;
            string classname = player.Class.ToString();
            string gender = player.Gender;
            MessageBox.Show($"{name} the {gender} {classname} attacks with {damage} damage.");
        }

        private void Defendbutton_Click(object sender, EventArgs e)
        {

            int incomingDamage = 10;
            combatController.PerformDefend(incomingDamage);
            int damageMitigated = player.CalculateDefense(incomingDamage);
            string name = player.Name;
            string classname = player.Class.ToString();
            string gender = player.Gender;

            // Display the result
            MessageBox.Show($"{name} the {gender} {classname} defends and mitigates {damageMitigated} damage.");
        }
    }
}
