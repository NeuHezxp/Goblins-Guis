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

            // Bind player properties to controls
            /*
            nameTextBox.DataBindings.Add("Text", playerCharacter, "Name");
            textBox1.DataBindings.Add("Text", playerCharacter, "Gender");
            classComboBox.DataSource = Enum.GetValues(typeof(Character.CharacterClass));
            classComboBox.DataBindings.Add("SelectedItem", playerCharacter, "Class");
            numericUpDownSTR.DataBindings.Add("Value", playerCharacter, "STR", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownDEX.DataBindings.Add("Value", playerCharacter, "DEX", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownCON.DataBindings.Add("Value", playerCharacter, "CON", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownINT.DataBindings.Add("Value", playerCharacter, "INT", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownWIS.DataBindings.Add("Value", playerCharacter, "WIS", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownCHA.DataBindings.Add("Value", playerCharacter, "CHA", false, DataSourceUpdateMode.OnPropertyChanged);
            */
        }

        private void StartButton_click(object sender, EventArgs e)
        {
            // Construct a string that contains the debug information
            string debugInfo = playerController.GetDebugInfo();

            // Display the debug information in a message box
            MessageBox.Show(debugInfo, "Debug Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public NumericUpDown StrengthNumericUpDown { get { return numericUpDownSTR; } }
        public NumericUpDown DexterityNumericUpDown { get { return numericUpDownDEX; } }
        public NumericUpDown ConstitutionNumericUpDown { get { return numericUpDownCON; } }
        public NumericUpDown IntelligenceNumericUpDown { get { return numericUpDownINT; } }
        public NumericUpDown WisdomNumericUpDown { get { return numericUpDownWIS; } }
        public NumericUpDown CharismaNumericUpDown { get { return numericUpDownCHA; } }

    }
}
