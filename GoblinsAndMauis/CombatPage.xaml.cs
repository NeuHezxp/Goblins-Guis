using GameLogic;

namespace GoblinsAndMauis;

public partial class CombatPage : ContentPage
{
    private Player player;
    private Enemy enemy;
    private CombatController combatController;
    public CombatPage(Player player, Enemy enemy)
    {
        InitializeComponent();
        this.player = player;
        this.enemy = enemy;

        this.player.HealthChanged += UpdatePlayerHealthBar;
        this.enemy.HealthChanged += UpdateEnemyHealthBar;

        combatController = new CombatController(this.player, this.enemy);

        // Initialize health bars
        playerHealthBar.Progress = (double)this.player.HP / player.MaxHP;
        enemyHealthBar.Progress = (double)this.enemy.HP / enemy.MaxHP;

        combatController = new CombatController(player, enemy);

        // Initial health bar updates
        UpdatePlayerHealthBar(this.player.HP);
        UpdateEnemyHealthBar(this.enemy.HP);
    }

    private void UpdatePlayerHealthBar(int newHealth)
    {
        // Ensure UI updates happen on the main thread
        MainThread.BeginInvokeOnMainThread(() =>
        {
            playerHealthBar.Progress = (double)newHealth / player.MaxHP;
        });
    }

    private void UpdateEnemyHealthBar(int newHealth)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            enemyHealthBar.Progress = (double)newHealth / enemy.MaxHP;
        });
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        // Unsubscribe from HealthChanged events if necessary
        // This might be handled automatically if the player and enemy objects are not long-lived;
    }   
    private async void OnAttackClicked(object sender, EventArgs e)
    {
        // Handles attack logic
        var message = combatController.PlayerAttack();
        await DisplayAlert("Attack", message, "OK");
        CheckEndCombat();
    }

    private async void OnDefendClicked(object sender, EventArgs e)
    {
        var message = combatController.PlayerDefend();
        await DisplayAlert("Defend", message, "OK");
        CheckEndCombat();
    }
    private async void OnStakeClicked(object sender, EventArgs e)
    {
        var message = combatController.PlayerStakeAttack();
        await DisplayAlert("Stake", message, "OK");
        CheckEndCombat();
    }

    private void OnFleeClicked(object sender, EventArgs e)
    {
        // Handle flee logic
    }
    private void CheckEndCombat()
    {
        if (combatController.EnemyDead())
        {
            player.LevelUp();
            EndCombat();
        }
        else if (combatController.PlayerDead())
        {
            DisplayAlert("Defeat", "You have been defeated!", "OK");
            // Handle player defeat, possibly navigate to a game over screen
        }
    }

    private async void EndCombat()
    {
        player.HP = player.MaxHP; // Reset player health to max or a specific recovery point
        enemy.HP = enemy.MaxHP; // Reset enemy health if needed

        await DisplayAlert("Victory", "Combat has ended!", "OK");

        // Navigate back to the previous page or a victory page
        await Navigation.PopToRootAsync();
    }
}