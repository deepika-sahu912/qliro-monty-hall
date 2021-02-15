namespace Qliro.MontyHallSimulator
{
    partial class Simulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.winResult = new System.Windows.Forms.Label();
            this.loseResult = new System.Windows.Forms.Label();
            this.winPercentage = new System.Windows.Forms.Label();
            this.winResultValue = new System.Windows.Forms.Label();
            this.lostResultValue = new System.Windows.Forms.Label();
            this.winPercValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number of Simulations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(41, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 29);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Switch Door";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // winResult
            // 
            this.winResult.AutoSize = true;
            this.winResult.ForeColor = System.Drawing.Color.DarkRed;
            this.winResult.Location = new System.Drawing.Point(41, 345);
            this.winResult.Name = "winResult";
            this.winResult.Size = new System.Drawing.Size(152, 25);
            this.winResult.TabIndex = 4;
            this.winResult.Text = "Number of Wins";
            this.winResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // loseResult
            // 
            this.loseResult.AutoSize = true;
            this.loseResult.ForeColor = System.Drawing.Color.DarkRed;
            this.loseResult.Location = new System.Drawing.Point(41, 385);
            this.loseResult.Name = "loseResult";
            this.loseResult.Size = new System.Drawing.Size(153, 25);
            this.loseResult.TabIndex = 5;
            this.loseResult.Text = "Number of loses";
            this.loseResult.Click += new System.EventHandler(this.loseResult_Click);
            // 
            // winPercentage
            // 
            this.winPercentage.AutoSize = true;
            this.winPercentage.ForeColor = System.Drawing.Color.DarkRed;
            this.winPercentage.Location = new System.Drawing.Point(41, 428);
            this.winPercentage.Name = "winPercentage";
            this.winPercentage.Size = new System.Drawing.Size(152, 25);
            this.winPercentage.TabIndex = 6;
            this.winPercentage.Text = "Win Percentage";
            // 
            // winResultValue
            // 
            this.winResultValue.AutoSize = true;
            this.winResultValue.ForeColor = System.Drawing.Color.DarkRed;
            this.winResultValue.Location = new System.Drawing.Point(343, 345);
            this.winResultValue.Name = "winResultValue";
            this.winResultValue.Size = new System.Drawing.Size(57, 25);
            this.winResultValue.TabIndex = 7;
            this.winResultValue.Text = "Wins";
            // 
            // lostResultValue
            // 
            this.lostResultValue.AutoSize = true;
            this.lostResultValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lostResultValue.Location = new System.Drawing.Point(343, 385);
            this.lostResultValue.Name = "lostResultValue";
            this.lostResultValue.Size = new System.Drawing.Size(55, 25);
            this.lostResultValue.TabIndex = 8;
            this.lostResultValue.Text = "Lose";
            // 
            // winPercValue
            // 
            this.winPercValue.AutoSize = true;
            this.winPercValue.ForeColor = System.Drawing.Color.DarkRed;
            this.winPercValue.Location = new System.Drawing.Point(344, 428);
            this.winPercValue.Name = "winPercValue";
            this.winPercValue.Size = new System.Drawing.Size(112, 25);
            this.winPercValue.TabIndex = 9;
            this.winPercValue.Text = "Percentage";
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 505);
            this.Controls.Add(this.winPercValue);
            this.Controls.Add(this.lostResultValue);
            this.Controls.Add(this.winResultValue);
            this.Controls.Add(this.winPercentage);
            this.Controls.Add(this.loseResult);
            this.Controls.Add(this.winResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Simulator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label winResult;
        private System.Windows.Forms.Label loseResult;
        private System.Windows.Forms.Label winPercentage;
        private System.Windows.Forms.Label winResultValue;
        private System.Windows.Forms.Label lostResultValue;
        private System.Windows.Forms.Label winPercValue;
    }
}

