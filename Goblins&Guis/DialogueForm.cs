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
            switch (buttonClickCount)
            {
                case 1:
                case 2:
                case 3:
                    if (controller.CanPerformStrAction(5 + buttonClickCount))
                    {
                        label2.Text = buttonClickCount == 1 ? controller.GetDialogueForAttribute("STR") :
                                      buttonClickCount == 2 ? controller.GetRandomMidDialogue() :
                                                              controller.GetRandomEndDialogue();
                    }
                    else
                    {
                        MessageBox.Show(buttonClickCount < 3 ? "You think you can Brute force me, huh?" : "You're weaker than I thought");
                        StartCombat();
                        buttonClickCount = 0; // Reset the count if combat starts
                    }
                    break;
                default:
                    StartCombat();
                    buttonClickCount = 0; // Reset the count for the next dialogue interaction
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
            switch (buttonClickCount)
            {
                case 1:
                case 2:
                case 3:
                    if (controller.CanPerformChaAction(5 + buttonClickCount))
                    {
                        label2.Text = buttonClickCount == 1 ? controller.GetDialogueForAttribute("CHA") :
                                      buttonClickCount == 2 ? controller.GetRandomMidDialogue() :
                                                              controller.GetRandomEndDialogue();
                    }
                    else
                    {
                        MessageBox.Show(buttonClickCount < 3 ? "You think you can Charm your way out of this huh?" : "You think i am some fool");
                        StartCombat();
                        buttonClickCount = 0; // Reset the count if combat starts
                    }
                    break;
                default:
                    StartCombat();
                    buttonClickCount = 0; // Reset the count for the next dialogue interaction
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
            switch (buttonClickCount)
            {
                case 1:
                case 2:
                case 3:
                    if (controller.CanPerformChaAction(5 + buttonClickCount))
                    {
                        label2.Text = buttonClickCount == 1 ? controller.GetDialogueForAttribute("WIS") :
                                      buttonClickCount == 2 ? controller.GetRandomMidDialogue() :
                                                              controller.GetRandomEndDialogue();
                    }
                    else
                    {
                        MessageBox.Show(buttonClickCount < 3 ? "You think you can Charm your way out of this huh?" : "You think i am some fool");
                        StartCombat();
                        buttonClickCount = 0; // Reset the count if combat starts
                    }
                    break;
                default:
                    StartCombat();
                    buttonClickCount = 0; // Reset the count for the next dialogue interaction
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
            switch (buttonClickCount)
            {
                case 1:
                case 2:
                case 3:
                    if (controller.CanPerformChaAction(5 + buttonClickCount))
                    {
                        label2.Text = buttonClickCount == 1 ? controller.GetDialogueForAttribute("DEX") :
                                      buttonClickCount == 2 ? controller.GetRandomMidDialogue() :
                                                              controller.GetRandomEndDialogue();
                    }
                    else
                    {
                        MessageBox.Show(buttonClickCount < 3 ? "You think you can Trick me huh?" : "You think i am some fool");
                        StartCombat();
                        buttonClickCount = 0; // Reset the count if combat starts
                    }
                    break;
                default:
                    StartCombat();
                    buttonClickCount = 0; // Reset the count for the next dialogue interaction
                    break;
            }
        }
        private void OnCombatEnded()
        {
            // Show the DialogueForm when combat ends
            this.Show();
        }

        private void DialogueForm_Load(object sender, EventArgs e)
        {

        }
    }
}
