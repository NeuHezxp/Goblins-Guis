using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goblins_Guis
{
    internal class PlayerController
    {
        private Player player;
        private Form CharacterCreationForm;
        public PlayerController(Player player, Form CharacterCreationForm)
        {
            this.player = player;
            this.CharacterCreationForm = CharacterCreationForm;
        }
        public string GetDebugInfo()
        {
            return $"Name: {player.Name},\n Gender: {player.Gender}\n STR:{player.STR},\n DEX:{player.DEX}\n CON:{player.CON}\n INT:{player.INT}\n WIS:{player.WIS}\n CHA:{player.CHA}\n CLASS:{player.Class} ";
        }
        public void BindProperties()
        {
            CharacterCreationForm form = (CharacterCreationForm)CharacterCreationForm;
            //form variables
            //var nameTextBox = (TextBox)CharacterCreationForm.Controls["nameTextBox"];
            //var textBox1 = (TextBox)CharacterCreationForm.Controls["textBox1"];
            //var classComboBox = (ComboBox)CharacterCreationForm.Controls["classComboBox"];
            var nameTextBox = CharacterCreationForm.Controls["nameTextBox"] as TextBox;
            var textBox1 = CharacterCreationForm.Controls["textBox1"] as TextBox;
            var classComboBox = CharacterCreationForm.Controls["classComboBox"] as ComboBox;
            // Bind the NumericUpDown controls
            form.StrengthNumericUpDown.DataBindings.Add("Value", player, "STR", false, DataSourceUpdateMode.OnPropertyChanged);
            form.DexterityNumericUpDown.DataBindings.Add("Value", player, "DEX", false, DataSourceUpdateMode.OnPropertyChanged);
            form.ConstitutionNumericUpDown.DataBindings.Add("Value", player, "CON", false, DataSourceUpdateMode.OnPropertyChanged);
            form.IntelligenceNumericUpDown.DataBindings.Add("Value", player, "INT", false, DataSourceUpdateMode.OnPropertyChanged);
            form.WisdomNumericUpDown.DataBindings.Add("Value", player, "WIS", false, DataSourceUpdateMode.OnPropertyChanged);
            form.CharismaNumericUpDown.DataBindings.Add("Value", player, "CHA", false, DataSourceUpdateMode.OnPropertyChanged);


            //name and textbox combo
            nameTextBox.DataBindings.Add("Text", player, "Name");
            textBox1.DataBindings.Add("Text", player, "Gender");
            classComboBox.DataSource = Enum.GetValues(typeof(Character.CharacterClass));
            classComboBox.DataBindings.Add("SelectedItem", player, "Class");

        }
    }
}