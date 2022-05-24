namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.operationsGroupBox = new System.Windows.Forms.GroupBox();
            this.sameButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.signButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.operationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(15, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8);
            this.textBox1.MaximumSize = new System.Drawing.Size(377, 61);
            this.textBox1.MinimumSize = new System.Drawing.Size(377, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 61);
            this.textBox1.TabIndex = 0;
            // 
            // operationsGroupBox
            // 
            this.operationsGroupBox.Controls.Add(this.sameButton);
            this.operationsGroupBox.Controls.Add(this.splitButton);
            this.operationsGroupBox.Controls.Add(this.multiplyButton);
            this.operationsGroupBox.Controls.Add(this.minusButton);
            this.operationsGroupBox.Controls.Add(this.plusButton);
            this.operationsGroupBox.Location = new System.Drawing.Point(240, 100);
            this.operationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.operationsGroupBox.Name = "operationsGroupBox";
            this.operationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.operationsGroupBox.Size = new System.Drawing.Size(152, 219);
            this.operationsGroupBox.TabIndex = 1;
            this.operationsGroupBox.TabStop = false;
            this.operationsGroupBox.Text = "Operaciones";
            // 
            // sameButton
            // 
            this.sameButton.BackColor = System.Drawing.Color.LawnGreen;
            this.sameButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sameButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sameButton.Location = new System.Drawing.Point(5, 155);
            this.sameButton.Margin = new System.Windows.Forms.Padding(2);
            this.sameButton.Name = "sameButton";
            this.sameButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sameButton.Size = new System.Drawing.Size(138, 51);
            this.sameButton.TabIndex = 16;
            this.sameButton.Text = "=";
            this.sameButton.UseVisualStyleBackColor = false;
            // 
            // splitButton
            // 
            this.splitButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.splitButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitButton.Location = new System.Drawing.Point(76, 94);
            this.splitButton.Margin = new System.Windows.Forms.Padding(2);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(66, 51);
            this.splitButton.TabIndex = 15;
            this.splitButton.Text = "/";
            this.splitButton.UseVisualStyleBackColor = false;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.multiplyButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplyButton.Location = new System.Drawing.Point(5, 94);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(66, 51);
            this.multiplyButton.TabIndex = 14;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.minusButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minusButton.Location = new System.Drawing.Point(76, 32);
            this.minusButton.Margin = new System.Windows.Forms.Padding(2);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(66, 51);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.plusButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plusButton.Location = new System.Drawing.Point(5, 32);
            this.plusButton.Margin = new System.Windows.Forms.Padding(2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(66, 51);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(15, 100);
            this.oneButton.Margin = new System.Windows.Forms.Padding(2);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(66, 51);
            this.oneButton.TabIndex = 2;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(86, 100);
            this.twoButton.Margin = new System.Windows.Forms.Padding(2);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(66, 51);
            this.twoButton.TabIndex = 3;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(158, 100);
            this.threeButton.Margin = new System.Windows.Forms.Padding(2);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(66, 51);
            this.threeButton.TabIndex = 4;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(158, 156);
            this.sixButton.Margin = new System.Windows.Forms.Padding(2);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(66, 51);
            this.sixButton.TabIndex = 7;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(86, 156);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(66, 51);
            this.fiveButton.TabIndex = 6;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(15, 156);
            this.fourButton.Margin = new System.Windows.Forms.Padding(2);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(66, 51);
            this.fourButton.TabIndex = 5;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            // 
            // pointButton
            // 
            this.pointButton.Location = new System.Drawing.Point(158, 268);
            this.pointButton.Margin = new System.Windows.Forms.Padding(2);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(66, 51);
            this.pointButton.TabIndex = 13;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(86, 268);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(2);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(66, 51);
            this.zeroButton.TabIndex = 12;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(15, 268);
            this.signButton.Margin = new System.Windows.Forms.Padding(2);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(66, 51);
            this.signButton.TabIndex = 11;
            this.signButton.Text = "+/-";
            this.signButton.UseVisualStyleBackColor = true;
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(158, 212);
            this.nineButton.Margin = new System.Windows.Forms.Padding(2);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(66, 51);
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(86, 212);
            this.eightButton.Margin = new System.Windows.Forms.Padding(2);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(66, 51);
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(15, 212);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(2);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(66, 51);
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 347);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.operationsGroupBox);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "d";
            this.operationsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox operationsGroupBox;
        private System.Windows.Forms.Button sameButton;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
    }
}
