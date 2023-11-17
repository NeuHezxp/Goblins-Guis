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
        private static readonly Random rand = new Random();
        private static readonly string[] ButtonTexts =
        {
            "Option 1",
            "Option 2",
            "Option 3",
            "Option 4"
        };
        internal DialogueForm(DialogueController controller)
        {
            InitializeComponent();
            this.controller = controller;

            // Set the NPC's name and initial dialogue
            label1.Text = controller.GetNPCName();
            label2.Text = controller.GetNPCDialogue();
        }


        private string GetRandomButtonText()
        {
            return ButtonTexts[rand.Next(ButtonTexts.Length)];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = controller.GetNewNPCDialogue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = controller.GetNewNPCDialogue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = controller.GetNewNPCDialogue();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = controller.GetNewNPCDialogue();
        }
    }
}
