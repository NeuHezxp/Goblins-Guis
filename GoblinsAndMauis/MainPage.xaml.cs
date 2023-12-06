using GameLogic;
using static GameLogic.Character;

namespace GoblinsAndMauis
{
    public partial class MainPage : ContentPage
    {
        private Player player;

       
       
        private void OnClassPickerChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedItem = (string)picker.SelectedItem;

            switch (selectedItem)
            {
                case "Warrior":
                    player.Class = CharacterClass.Warrior;
                    break;
                case "Mage":
                    player.Class = CharacterClass.Mage;
                    break;
                case "Archer":
                    player.Class = CharacterClass.Archer;
                    break;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            player = new Player();
            BindingContext = player; // Set the BindingContext to enable data binding
                                     // Populate the Picker with enum values
        }
        private async void OnNextLevelClicked(object sender, EventArgs e)
        {
            DialogueController controller = new DialogueController(player);
            await Navigation.PushAsync(new DialoguePage(controller));
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Instead of incrementing the count, display the player's name
            CounterBtn.Text = "Create Character";
            clickCountLabel.Text = $"Player Name: {player.Name}, " +
                            $"Gender: {player.Gender}, " +
                            $"STR: {player.STR}, " +
                            $"DEX: {player.DEX}, " +
                            $"CON: {player.CON}, " +
                            $"INT: {player.INT}, " +
                            $"WIS: {player.WIS}, " +
                            $"CHA: {player.CHA}" +
                            $"Class:{player.Class}";
           

            // If you still want to announce something, you can change it to announce the player's name
            SemanticScreenReader.Announce($"Player Name: {player.Name}");
        }
    }
}