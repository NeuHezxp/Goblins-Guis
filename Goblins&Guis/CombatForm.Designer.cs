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
            playerHP_label = new Label();
            EnemyHP_label = new Label();
            SuspendLayout();
            // 
            // Flee_Button
            // 
            Flee_Button.Location = new Point(336, 399);
            Flee_Button.Name = "Flee_Button";
            Flee_Button.Size = new Size(75, 23);
            Flee_Button.TabIndex = 0;
            Flee_Button.Text = "Flee";
            Flee_Button.UseVisualStyleBackColor = true;
            Flee_Button.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 349);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Attack";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Defendbutton
            // 
            Defendbutton.Location = new Point(422, 349);
            Defendbutton.Name = "Defendbutton";
            Defendbutton.Size = new Size(75, 23);
            Defendbutton.TabIndex = 2;
            Defendbutton.Text = "Defend";
            Defendbutton.UseVisualStyleBackColor = true;
            Defendbutton.Click += Defendbutton_Click;
            // 
            // EnemyName_label
            // 
            EnemyName_label.AutoSize = true;
            EnemyName_label.Location = new Point(321, 9);
            EnemyName_label.Name = "EnemyName_label";
            EnemyName_label.Size = new Size(105, 15);
            EnemyName_label.TabIndex = 3;
            EnemyName_label.Text = "EnemyName_label";
            // 
            // EnemyDialogue_label
            // 
            EnemyDialogue_label.AutoSize = true;
            EnemyDialogue_label.Location = new Point(321, 43);
            EnemyDialogue_label.Name = "EnemyDialogue_label";
            EnemyDialogue_label.Size = new Size(120, 15);
            EnemyDialogue_label.TabIndex = 4;
            EnemyDialogue_label.Text = "EnemyDialogue_label";
            // 
            // playerHP_label
            // 
            playerHP_label.AutoSize = true;
            playerHP_label.Location = new Point(362, 357);
            playerHP_label.Name = "playerHP_label";
            playerHP_label.Size = new Size(23, 15);
            playerHP_label.TabIndex = 5;
            playerHP_label.Text = "HP";
            // 
            // EnemyHP_label
            // 
            EnemyHP_label.AutoSize = true;
            EnemyHP_label.Location = new Point(362, 83);
            EnemyHP_label.Name = "EnemyHP_label";
            EnemyHP_label.Size = new Size(23, 15);
            EnemyHP_label.TabIndex = 6;
            EnemyHP_label.Text = "HP";
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnemyHP_label);
            Controls.Add(playerHP_label);
            Controls.Add(EnemyDialogue_label);
            Controls.Add(EnemyName_label);
            Controls.Add(Defendbutton);
            Controls.Add(button2);
            Controls.Add(Flee_Button);
            Name = "CombatForm";
            Text = "CombatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Flee_Button;
        private Button button2;
        private Button Defendbutton;
        private Label EnemyName_label;
        private Label EnemyDialogue_label;
        private Label playerHP_label;
        private Label EnemyHP_label;
    }
}