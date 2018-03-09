namespace CaseConversion
{
    partial class Form1
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.UpperCaseLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.UpperCaseAns = new System.Windows.Forms.TextBox();
            this.BinaryLabel = new System.Windows.Forms.Label();
            this.BinaryAns = new System.Windows.Forms.TextBox();
            this.HexLabel = new System.Windows.Forms.Label();
            this.HexAns = new System.Windows.Forms.TextBox();
            this.ASCIILabel = new System.Windows.Forms.Label();
            this.ASCIIAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(133, 44);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(98, 36);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // UpperCaseLabel
            // 
            this.UpperCaseLabel.AutoSize = true;
            this.UpperCaseLabel.Location = new System.Drawing.Point(12, 142);
            this.UpperCaseLabel.Name = "UpperCaseLabel";
            this.UpperCaseLabel.Size = new System.Drawing.Size(132, 25);
            this.UpperCaseLabel.TabIndex = 1;
            this.UpperCaseLabel.Text = "Upper Case:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 47);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 31);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // UpperCaseAns
            // 
            this.UpperCaseAns.Location = new System.Drawing.Point(167, 139);
            this.UpperCaseAns.Name = "UpperCaseAns";
            this.UpperCaseAns.ReadOnly = true;
            this.UpperCaseAns.Size = new System.Drawing.Size(125, 31);
            this.UpperCaseAns.TabIndex = 3;
            this.UpperCaseAns.TextChanged += new System.EventHandler(this.UpperCaseAns_TextChanged);
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.AutoSize = true;
            this.BinaryLabel.Location = new System.Drawing.Point(12, 183);
            this.BinaryLabel.Name = "BinaryLabel";
            this.BinaryLabel.Size = new System.Drawing.Size(140, 25);
            this.BinaryLabel.TabIndex = 4;
            this.BinaryLabel.Text = "Binary Value:";
            // 
            // BinaryAns
            // 
            this.BinaryAns.Location = new System.Drawing.Point(167, 177);
            this.BinaryAns.Name = "BinaryAns";
            this.BinaryAns.ReadOnly = true;
            this.BinaryAns.Size = new System.Drawing.Size(125, 31);
            this.BinaryAns.TabIndex = 5;
            this.BinaryAns.TextChanged += new System.EventHandler(this.BinaryAns_TextChanged);
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Location = new System.Drawing.Point(12, 223);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(117, 25);
            this.HexLabel.TabIndex = 6;
            this.HexLabel.Text = "Hex Value:";
            // 
            // HexAns
            // 
            this.HexAns.Location = new System.Drawing.Point(167, 217);
            this.HexAns.Name = "HexAns";
            this.HexAns.ReadOnly = true;
            this.HexAns.Size = new System.Drawing.Size(125, 31);
            this.HexAns.TabIndex = 7;
            this.HexAns.TextChanged += new System.EventHandler(this.HexAns_TextChanged);
            // 
            // ASCIILabel
            // 
            this.ASCIILabel.AutoSize = true;
            this.ASCIILabel.Location = new System.Drawing.Point(12, 106);
            this.ASCIILabel.Name = "ASCIILabel";
            this.ASCIILabel.Size = new System.Drawing.Size(71, 25);
            this.ASCIILabel.TabIndex = 8;
            this.ASCIILabel.Text = "ASCII:";
            // 
            // ASCIIAns
            // 
            this.ASCIIAns.Location = new System.Drawing.Point(167, 100);
            this.ASCIIAns.Name = "ASCIIAns";
            this.ASCIIAns.ReadOnly = true;
            this.ASCIIAns.Size = new System.Drawing.Size(125, 31);
            this.ASCIIAns.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 371);
            this.Controls.Add(this.ASCIIAns);
            this.Controls.Add(this.ASCIILabel);
            this.Controls.Add(this.HexAns);
            this.Controls.Add(this.HexLabel);
            this.Controls.Add(this.BinaryAns);
            this.Controls.Add(this.BinaryLabel);
            this.Controls.Add(this.UpperCaseAns);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.UpperCaseLabel);
            this.Controls.Add(this.EnterButton);
            this.Name = "Form1";
            this.Text = "Case Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label UpperCaseLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox UpperCaseAns;
        private System.Windows.Forms.Label BinaryLabel;
        private System.Windows.Forms.TextBox BinaryAns;
        private System.Windows.Forms.Label HexLabel;
        private System.Windows.Forms.TextBox HexAns;
        private System.Windows.Forms.Label ASCIILabel;
        private System.Windows.Forms.TextBox ASCIIAns;
    }
}

