using GameLogic;

namespace GoblinsAndMauis;

public partial class DialoguePage : ContentPage
{
    private DialogueController controller;
    int count = 0;
    public int Count
    {
        get => count;
        set { count = value; OnPropertyChanged(); }
    }
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
    private async void StartCombat()
    {
        Player player = controller.GetPlayer();
        Enemy enemy = new Enemy();  
        CombatPage combatPage = new CombatPage(player, enemy);

        // Navigate to the combat page
        await Navigation.PushAsync(combatPage);
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
        count++;
        switch (count)
        {
            case 1:
            case 2:
            case 3:
                if (controller.CanPerformStrAction(5 + count))
                {
                    dialogueTextLabel.Text = count == 1 ? controller.GetDialogueForAttribute("STR") :
                                  count == 2 ? controller.GetRandomMidDialogue() :
                                                          controller.GetRandomEndDialogue();
                }
                else
                {
                    //Show(count < 3 ? "You think you can Brute force me, huh?" : "You're weaker than I thought");
                    StartCombat();
                    count = 0; // Reset the count if combat starts
                }
                break;
            default:
                StartCombat();
                count = 0; // Reset the count for the next dialogue interaction
                break;
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        count++;
        switch (count)
        {
            case 1:
            case 2:
            case 3:
                if (controller.CanPerformChaAction(5 + count))
                {
                    dialogueTextLabel.Text = count == 1 ? controller.GetDialogueForAttribute("CHA") :
                                  count == 2 ? controller.GetRandomMidDialogue() :
                                                          controller.GetRandomEndDialogue();
                }
                else
                {
                    //Show(count < 3 ? "You think you can Charm your way out of this huh?" : "You think i am some fool");
                    StartCombat();
                    count = 0; // Reset the count if combat starts
                }
                break;
            default:
                StartCombat();
                count = 0; // Reset the count for the next dialogue interaction
                break;
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        count++;
        switch (count)
        {
            case 1:
            case 2:
            case 3:
                if (controller.CanPerformChaAction(5 + count))
                {
                    dialogueTextLabel.Text = count == 1 ? controller.GetDialogueForAttribute("INT") :
                                  count == 2 ? controller.GetRandomMidDialogue() :
                                                          controller.GetRandomEndDialogue();
                }
                else
                {
                    //Show(count < 3 ? "You think you're smarter than me huh?" : "You think i am some fool");
                    StartCombat();
                    count = 0; // Reset the count if combat starts
                }
                break;
            default:
                StartCombat();
                count = 0; // Reset the count for the next dialogue interaction
                break;
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        count++;
        switch (count)
        {
            case 1:
            case 2:
            case 3:
                if (controller.CanPerformChaAction(5 + count))
                {
                    dialogueTextLabel.Text = count == 1 ? controller.GetDialogueForAttribute("DEX") :
                                  count == 2 ? controller.GetRandomMidDialogue() :
                                                          controller.GetRandomEndDialogue();
                }
                else
                {
                    //Show(count < 3 ? "You think you can Trick me huh?" : "You think i am some fool");
                    StartCombat();
                    count = 0; // Reset the count if combat starts
                }
                break;
            default:
                StartCombat();
                count = 0; // Reset the count for the next dialogue interaction
                break;
        }
    }
    
}