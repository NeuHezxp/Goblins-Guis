namespace Goblins_Guis
{
    partial class CharacterCreationForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            nameTextBox = new TextBox();
            classComboBox = new ComboBox();
            StartButton = new Button();
            numericUpDownSTR = new NumericUpDown();
            numericUpDownDEX = new NumericUpDown();
            numericUpDownCON = new NumericUpDown();
            numericUpDownWIS = new NumericUpDown();
            numericUpDownINT = new NumericUpDown();
            numericUpDownCHA = new NumericUpDown();
            groupBox1 = new GroupBox();
            STRlabel = new Label();
            DEXlabel = new Label();
            CONlabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSTR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDEX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWIS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownINT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCHA).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(77, 57);
            nameTextBox.Margin = new Padding(4, 5, 4, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(141, 31);
            nameTextBox.TabIndex = 1;
            // 
            // classComboBox
            // 
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(440, 393);
            classComboBox.Margin = new Padding(4, 5, 4, 5);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(171, 33);
            classComboBox.TabIndex = 2;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(511, 583);
            StartButton.Margin = new Padding(4, 5, 4, 5);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(107, 38);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start Journey";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_click;
            // 
            // numericUpDownSTR
            // 
            numericUpDownSTR.Location = new Point(33, 20);
            numericUpDownSTR.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSTR.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSTR.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSTR.Name = "numericUpDownSTR";
            numericUpDownSTR.Size = new Size(171, 31);
            numericUpDownSTR.TabIndex = 4;
            numericUpDownSTR.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownDEX
            // 
            numericUpDownDEX.Location = new Point(33, 68);
            numericUpDownDEX.Margin = new Padding(4, 5, 4, 5);
            numericUpDownDEX.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDEX.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDEX.Name = "numericUpDownDEX";
            numericUpDownDEX.Size = new Size(171, 31);
            numericUpDownDEX.TabIndex = 5;
            numericUpDownDEX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCON
            // 
            numericUpDownCON.Location = new Point(33, 117);
            numericUpDownCON.Margin = new Padding(4, 5, 4, 5);
            numericUpDownCON.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCON.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCON.Name = "numericUpDownCON";
            numericUpDownCON.Size = new Size(171, 31);
            numericUpDownCON.TabIndex = 6;
            numericUpDownCON.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownWIS
            // 
            numericUpDownWIS.Location = new Point(33, 213);
            numericUpDownWIS.Margin = new Padding(4, 5, 4, 5);
            numericUpDownWIS.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownWIS.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWIS.Name = "numericUpDownWIS";
            numericUpDownWIS.Size = new Size(171, 31);
            numericUpDownWIS.TabIndex = 7;
            numericUpDownWIS.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownINT
            // 
            numericUpDownINT.Location = new Point(33, 165);
            numericUpDownINT.Margin = new Padding(4, 5, 4, 5);
            numericUpDownINT.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownINT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownINT.Name = "numericUpDownINT";
            numericUpDownINT.Size = new Size(171, 31);
            numericUpDownINT.TabIndex = 8;
            numericUpDownINT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCHA
            // 
            numericUpDownCHA.Location = new Point(33, 262);
            numericUpDownCHA.Margin = new Padding(4, 5, 4, 5);
            numericUpDownCHA.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCHA.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCHA.Name = "numericUpDownCHA";
            numericUpDownCHA.Size = new Size(171, 31);
            numericUpDownCHA.TabIndex = 9;
            numericUpDownCHA.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownSTR);
            groupBox1.Controls.Add(numericUpDownDEX);
            groupBox1.Controls.Add(numericUpDownCHA);
            groupBox1.Controls.Add(numericUpDownCON);
            groupBox1.Controls.Add(numericUpDownINT);
            groupBox1.Controls.Add(numericUpDownWIS);
            groupBox1.Location = new Point(409, 38);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(286, 320);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "statBox";
            // 
            // STRlabel
            // 
            STRlabel.AutoSize = true;
            STRlabel.Location = new Point(363, 70);
            STRlabel.Margin = new Padding(4, 0, 4, 0);
            STRlabel.Name = "STRlabel";
            STRlabel.Size = new Size(42, 25);
            STRlabel.TabIndex = 11;
            STRlabel.Text = "STR";
            // 
            // DEXlabel
            // 
            DEXlabel.AutoSize = true;
            DEXlabel.Location = new Point(363, 120);
            DEXlabel.Margin = new Padding(4, 0, 4, 0);
            DEXlabel.Name = "DEXlabel";
            DEXlabel.Size = new Size(45, 25);
            DEXlabel.TabIndex = 12;
            DEXlabel.Text = "DEX";
            // 
            // CONlabel
            // 
            CONlabel.AutoSize = true;
            CONlabel.Location = new Point(363, 168);
            CONlabel.Margin = new Padding(4, 0, 4, 0);
            CONlabel.Name = "CONlabel";
            CONlabel.Size = new Size(50, 25);
            CONlabel.TabIndex = 13;
            CONlabel.Text = "CON";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 153);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(10, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 24);
            label1.TabIndex = 15;
            label1.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(10, 163);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 16;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Himalaya", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(363, 405);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 17;
            label3.Text = "Class:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 25);
            label4.TabIndex = 18;
            label4.Text = "INT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 265);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 19;
            label5.Text = "WIS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 313);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 20;
            label6.Text = "CHA";
            // 
            // CharacterCreationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 750);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(CONlabel);
            Controls.Add(DEXlabel);
            Controls.Add(STRlabel);
            Controls.Add(groupBox1);
            Controls.Add(StartButton);
            Controls.Add(classComboBox);
            Controls.Add(nameTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CharacterCreationForm";
            Text = "CharacterCreationForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSTR).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDEX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCON).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWIS).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownINT).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCHA).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox nameTextBox;
        private ComboBox classComboBox;
        private Button StartButton;
        private NumericUpDown numericUpDownSTR;
        private NumericUpDown numericUpDownDEX;
        private NumericUpDown numericUpDownCON;
        private NumericUpDown numericUpDownWIS;
        private NumericUpDown numericUpDownINT;
        private NumericUpDown numericUpDownCHA;
        private GroupBox groupBox1;
        private Label STRlabel;
        private Label DEXlabel;
        private Label CONlabel;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}