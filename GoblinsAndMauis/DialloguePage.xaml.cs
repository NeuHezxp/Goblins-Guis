using GameLogic;

namespace GoblinsAndMauis;

public partial class DialoguePage : ContentPage
{
    private DialogueController controller;
    private int buttonClickCount = 0;
    private Player player;
	public DialoguePage(DialogueController controller)
	{
		InitializeComponent();
        this.player = player;
        this.controller = controller;

        npcNameLabel.Text = controller.GetNPCName();
        dialogueTextLabel.Text = controller.GetNPCDialogue();

        // Set button texts
        choiceButton1.Text = "OverPower";
        choiceButton2.Text = "Charm Him?";
        choiceButton3.Text = "OutSmart Him";
        choiceButton4.Text = "Trip Him Up";

        //for binding in the xaml
        BindingContext = this.player;
    }
    private void OnChoiceClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        // Implement your logic based on the button clicked
        // For example, you can use button.Text or button's name
    }
}