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
            button2.Location = new Point(237, 255);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Attack";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Defendbutton
            // 
            Defendbutton.Location = new Point(434, 255);
            Defendbutton.Name = "Defendbutton";
            Defendbutton.Size = new Size(75, 23);
            Defendbutton.TabIndex = 2;
            Defendbutton.Text = "Defend";
            Defendbutton.UseVisualStyleBackColor = true;
            Defendbutton.Click += Defendbutton_Click;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Defendbutton);
            Controls.Add(button2);
            Controls.Add(Flee_Button);
            Name = "CombatForm";
            Text = "CombatForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Flee_Button;
        private Button button2;
        private Button Defendbutton;
    }
}