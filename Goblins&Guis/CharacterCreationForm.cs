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
    public partial class CharacterCreationForm : Form
    {
        private Player playerCharacter;
        private PlayerController playerController;

        public CharacterCreationForm()
        {
            InitializeComponent();

            playerCharacter = new Player();
            playerController = new PlayerController(playerCharacter, this);
            playerController.BindProperties();
        }

        private void StartButton_click(object sender, EventArgs e)
        {
            DialogueController dialogueController = new DialogueController();

            // Create an instance of the DialogueForm
            DialogueForm dialogueForm = new DialogueForm(dialogueController);

            // Show the DialogueForm
            dialogueForm.Show();
             //this.Close();
        }

        public NumericUpDown StrengthNumericUpDown { get { return numericUpDownSTR; } }
        public NumericUpDown DexterityNumericUpDown { get { return numericUpDownDEX; } }
        public NumericUpDown ConstitutionNumericUpDown { get { return numericUpDownCON; } }
        public NumericUpDown IntelligenceNumericUpDown { get { return numericUpDownINT; } }
        public NumericUpDown WisdomNumericUpDown { get { return numericUpDownWIS; } }
        public NumericUpDown CharismaNumericUpDown { get { return numericUpDownCHA; } }

    }
}
