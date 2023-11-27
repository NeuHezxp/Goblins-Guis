namespace Goblins_Guis
{
    partial class CombatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Flee_Button = new Button();
            button2 = new Button();
            Defendbutton = new Button();
            EnemyName_label = new Label();
            EnemyDialogue_label = new Label();
            enemyHealthProgressBar = new ProgressBar();
            healthProgressBar = new ProgressBar();
            stakeButton = new Button();
            SuspendLayout();
            // 
            // Flee_Button
            // 
            Flee_Button.Location = new Point(475, 658);
            Flee_Button.Margin = new Padding(4, 5, 4, 5);
            Flee_Button.Name = "Flee_Button";
            Flee_Button.Size = new Size(107, 38);
            Flee_Button.TabIndex = 0;
            Flee_Button.Text = "Flee";
            Flee_Button.UseVisualStyleBackColor = true;
            Flee_Button.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(293, 582);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 1;
            button2.Text = "Attack";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Defendbutton
            // 
            Defendbutton.Location = new Point(666, 582);
            Defendbutton.Margin = new Padding(4, 5, 4, 5);
            Defendbutton.Name = "Defendbutton";
            Defendbutton.Size = new Size(107, 38);
            Defendbutton.TabIndex = 2;
            Defendbutton.Text = "Defend";
            Defendbutton.UseVisualStyleBackColor = true;
            Defendbutton.Click += Defendbutton_Click;
            // 
            // EnemyName_label
            // 
            EnemyName_label.AutoSize = true;
            EnemyName_label.Location = new Point(459, 15);
            EnemyName_label.Margin = new Padding(4, 0, 4, 0);
            EnemyName_label.Name = "EnemyName_label";
            EnemyName_label.Size = new Size(156, 25);
            EnemyName_label.TabIndex = 3;
            EnemyName_label.Text = "EnemyName_label";
            // 
            // EnemyDialogue_label
            // 
            EnemyDialogue_label.AutoSize = true;
            EnemyDialogue_label.Location = new Point(459, 72);
            EnemyDialogue_label.Margin = new Padding(4, 0, 4, 0);
            EnemyDialogue_label.Name = "EnemyDialogue_label";
            EnemyDialogue_label.Size = new Size(180, 25);
            EnemyDialogue_label.TabIndex = 4;
            EnemyDialogue_label.Text = "EnemyDialogue_label";
            // 
            // enemyHealthProgressBar
            // 
            enemyHealthProgressBar.Location = new Point(466, 130);
            enemyHealthProgressBar.Margin = new Padding(4, 5, 4, 5);
            enemyHealthProgressBar.Name = "enemyHealthProgressBar";
            enemyHealthProgressBar.Size = new Size(143, 38);
            enemyHealthProgressBar.TabIndex = 5;
            // 
            // healthProgressBar
            // 
            healthProgressBar.Location = new Point(459, 582);
            healthProgressBar.Margin = new Padding(4, 5, 4, 5);
            healthProgressBar.Name = "healthProgressBar";
            healthProgressBar.Size = new Size(143, 38);
            healthProgressBar.TabIndex = 6;
            // 
            // stakeButton
            // 
            stakeButton.Location = new Point(475, 486);
            stakeButton.Margin = new Padding(4, 5, 4, 5);
            stakeButton.Name = "stakeButton";
            stakeButton.Size = new Size(107, 38);
            stakeButton.TabIndex = 7;
            stakeButton.Text = "Stake";
            stakeButton.UseVisualStyleBackColor = true;
            stakeButton.Click += stakeButton_Click;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(stakeButton);
            Controls.Add(healthProgressBar);
            Controls.Add(enemyHealthProgressBar);
            Controls.Add(EnemyDialogue_label);
            Controls.Add(EnemyName_label);
            Controls.Add(Defendbutton);
            Controls.Add(button2);
            Controls.Add(Flee_Button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CombatForm";
            Text = "CombatForm";
            Load += CombatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Flee_Button;
        private Button button2;
        private Button Defendbutton;
        private Label EnemyName_label;
        private Label EnemyDialogue_label;
        private ProgressBar enemyHealthProgressBar;
        private ProgressBar healthProgressBar;
        private Button stakeButton;
    }
}