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

        public CharacterCreationForm()
        {
            InitializeComponent();

            playerCharacter = new Player();
            // Bind player properties to controls
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
            // ... and so on for other properties
        }

        private void StartButton_click(object sender, EventArgs e)
        {
            // Construct a string that contains the debug information
            string debugMessage = $"Name: {playerCharacter.Name}\n" +
                                  $"Gender: {playerCharacter.Gender}\n" +
                                  $"Class: {playerCharacter.Class}\n" +
                                  $"STR: {playerCharacter.STR}\n" +
                                  $"DEX: {playerCharacter.DEX}\n" +
                                  $"CON: {playerCharacter.CON}\n" +
                                  $"INT: {playerCharacter.INT}\n" +
                                  $"WIS: {playerCharacter.WIS}\n" +
                                  $"CHA: {playerCharacter.CHA}";

            // Display the debug information in a message box
            MessageBox.Show(debugMessage, "Debug Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CONlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
