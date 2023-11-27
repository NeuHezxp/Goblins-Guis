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
using System.Xml.Linq;

namespace Goblins_Guis
{
    public partial class DialogueForm : Form
    {

        private DialogueController controller;
        private int buttonClickCount = 0;
        private static readonly Random rand = new Random();
        internal DialogueForm(DialogueController controller)
        {
            InitializeComponent();
            this.controller = controller;

            // Set the NPC's name and initial dialogue
            label1.Text = controller.GetNPCName();
            label2.Text = controller.GetNPCDialogue();

            button1.Text = "OverPower";
            button2.Text = "Charm Him?";
            button3.Text = "";
            button4.Text = "";
        }
        private void StartCombat()
        {
            Player player = controller.GetPlayer();
            Enemy enemy = new Enemy(); // Create an enemy instance
            CombatForm combatForm = new CombatForm(player, enemy);
            combatForm.CombatEnded += OnCombatEnded;

            combatForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonClickCount++;

            if (buttonClickCount == 1)
            {
                if (controller.CanPerformStrAction(6))
                {
                    label2.Text = controller.GetDialogueForAttribute("STR");
                }
                else
                {
                    MessageBox.Show("You think you can Brute force me huh?.");
                    StartCombat();
                }
            }
            else if (buttonClickCount == 2)
            {
                label2.Text = controller.GetNewNPCDialogue(); 
                                                              
                buttonClickCount = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClickCount++;

            if (buttonClickCount == 1)
            {
                if (controller.CanPerformStrAction(5))
                {
                    label2.Text = controller.GetDialogueForAttribute("CHA");
                }
                else
                {
                    MessageBox.Show("You arent that good lookin?.");
                    StartCombat();
                }
            }
            else if (buttonClickCount == 2)
            {
                label2.Text = controller.GetNewNPCDialogue();

                buttonClickCount = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClickCount++;

            if (buttonClickCount == 1)
            {
                if (controller.CanPerformStrAction(5))
                {
                    label2.Text = controller.GetDialogueForAttribute("STR");
                }
                else
                {
                    MessageBox.Show("You think you can Brute force me huh?.");
                    StartCombat();
                }
            }
            else if (buttonClickCount == 2)
            {
                label2.Text = controller.GetNewNPCDialogue();

                buttonClickCount = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClickCount++;

            if (buttonClickCount == 1)
            {
                if (controller.CanPerformStrAction(5))
                {
                    label2.Text = controller.GetDialogueForAttribute("STR");
                }
                else
                {
                    MessageBox.Show("You think you can Brute force me huh?.");
                    StartCombat();
                }
            }
            else if (buttonClickCount == 2)
            {
                label2.Text = controller.GetNewNPCDialogue();

                buttonClickCount = 0;
            }
        }
        private void OnCombatEnded()
        {
            // Show the DialogueForm when combat ends
            this.Show();
        }
    }
}
