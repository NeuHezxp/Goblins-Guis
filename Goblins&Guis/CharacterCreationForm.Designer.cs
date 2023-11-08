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
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(54, 34);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 1;
            // 
            // classComboBox
            // 
            classComboBox.Enabled = false;
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(308, 236);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(121, 23);
            classComboBox.TabIndex = 2;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(358, 350);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start Journey";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_click;
            // 
            // numericUpDownSTR
            // 
            numericUpDownSTR.Location = new Point(23, 12);
            numericUpDownSTR.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSTR.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSTR.Name = "numericUpDownSTR";
            numericUpDownSTR.Size = new Size(120, 23);
            numericUpDownSTR.TabIndex = 4;
            numericUpDownSTR.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownDEX
            // 
            numericUpDownDEX.Location = new Point(23, 41);
            numericUpDownDEX.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDEX.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDEX.Name = "numericUpDownDEX";
            numericUpDownDEX.Size = new Size(120, 23);
            numericUpDownDEX.TabIndex = 5;
            numericUpDownDEX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCON
            // 
            numericUpDownCON.Location = new Point(23, 70);
            numericUpDownCON.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCON.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCON.Name = "numericUpDownCON";
            numericUpDownCON.Size = new Size(120, 23);
            numericUpDownCON.TabIndex = 6;
            numericUpDownCON.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownWIS
            // 
            numericUpDownWIS.Location = new Point(23, 128);
            numericUpDownWIS.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownWIS.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWIS.Name = "numericUpDownWIS";
            numericUpDownWIS.Size = new Size(120, 23);
            numericUpDownWIS.TabIndex = 7;
            numericUpDownWIS.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownINT
            // 
            numericUpDownINT.Location = new Point(23, 99);
            numericUpDownINT.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownINT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownINT.Name = "numericUpDownINT";
            numericUpDownINT.Size = new Size(120, 23);
            numericUpDownINT.TabIndex = 8;
            numericUpDownINT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCHA
            // 
            numericUpDownCHA.Location = new Point(23, 157);
            numericUpDownCHA.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCHA.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCHA.Name = "numericUpDownCHA";
            numericUpDownCHA.Size = new Size(120, 23);
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
            groupBox1.Location = new Point(286, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 192);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "statBox";
            // 
            // STRlabel
            // 
            STRlabel.AutoSize = true;
            STRlabel.Location = new Point(254, 42);
            STRlabel.Name = "STRlabel";
            STRlabel.Size = new Size(26, 15);
            STRlabel.TabIndex = 11;
            STRlabel.Text = "STR";
            // 
            // DEXlabel
            // 
            DEXlabel.AutoSize = true;
            DEXlabel.Location = new Point(254, 72);
            DEXlabel.Name = "DEXlabel";
            DEXlabel.Size = new Size(28, 15);
            DEXlabel.TabIndex = 12;
            DEXlabel.Text = "DEX";
            // 
            // CONlabel
            // 
            CONlabel.AutoSize = true;
            CONlabel.Location = new Point(254, 101);
            CONlabel.Name = "CONlabel";
            CONlabel.Size = new Size(33, 15);
            CONlabel.TabIndex = 13;
            CONlabel.Text = "CON";
           
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(7, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 16);
            label1.TabIndex = 15;
            label1.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(7, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 16;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Himalaya", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(254, 243);
            label3.Name = "label3";
            label3.Size = new Size(33, 16);
            label3.TabIndex = 17;
            label3.Text = "Class:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 130);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 18;
            label4.Text = "INT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 159);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 19;
            label5.Text = "WIS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 188);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 20;
            label6.Text = "CHA";
            // 
            // CharacterCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
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