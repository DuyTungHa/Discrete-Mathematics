namespace BitString
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
            this.label1 = new System.Windows.Forms.Label();
            this.fixButton = new System.Windows.Forms.Button();
            this.aLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.andLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xorLabel = new System.Windows.Forms.Label();
            this.characterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.a0Button = new System.Windows.Forms.Button();
            this.a1Button = new System.Windows.Forms.Button();
            this.b0Button = new System.Windows.Forms.Button();
            this.b1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characterNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many characters?";
            // 
            // fixButton
            // 
            this.fixButton.Location = new System.Drawing.Point(242, 14);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(75, 23);
            this.fixButton.TabIndex = 2;
            this.fixButton.Text = "Fix";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(14, 42);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(59, 13);
            this.aLabel.TabIndex = 3;
            this.aLabel.Text = "Bit String A";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(136, 39);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 4;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(14, 69);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(59, 13);
            this.bLabel.TabIndex = 5;
            this.bLabel.Text = "Bit String B";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(136, 66);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(243, 41);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 45);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "RESULTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "AND";
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Location = new System.Drawing.Point(136, 140);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(35, 13);
            this.andLabel.TabIndex = 10;
            this.andLabel.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "OR";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(136, 157);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(35, 13);
            this.orLabel.TabIndex = 12;
            this.orLabel.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "XOR";
            // 
            // xorLabel
            // 
            this.xorLabel.AutoSize = true;
            this.xorLabel.Location = new System.Drawing.Point(136, 174);
            this.xorLabel.Name = "xorLabel";
            this.xorLabel.Size = new System.Drawing.Size(41, 13);
            this.xorLabel.TabIndex = 14;
            this.xorLabel.Text = "label10";
            // 
            // characterNumericUpDown
            // 
            this.characterNumericUpDown.Location = new System.Drawing.Point(136, 14);
            this.characterNumericUpDown.Name = "characterNumericUpDown";
            this.characterNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.characterNumericUpDown.TabIndex = 15;
            // 
            // a0Button
            // 
            this.a0Button.Location = new System.Drawing.Point(79, 39);
            this.a0Button.Name = "a0Button";
            this.a0Button.Size = new System.Drawing.Size(24, 23);
            this.a0Button.TabIndex = 16;
            this.a0Button.Text = "0";
            this.a0Button.UseVisualStyleBackColor = true;
            this.a0Button.Click += new System.EventHandler(this.a0Button_Click);
            // 
            // a1Button
            // 
            this.a1Button.Location = new System.Drawing.Point(109, 39);
            this.a1Button.Name = "a1Button";
            this.a1Button.Size = new System.Drawing.Size(21, 23);
            this.a1Button.TabIndex = 17;
            this.a1Button.Text = "1";
            this.a1Button.UseVisualStyleBackColor = true;
            this.a1Button.Click += new System.EventHandler(this.a1Button_Click);
            // 
            // b0Button
            // 
            this.b0Button.Location = new System.Drawing.Point(79, 66);
            this.b0Button.Name = "b0Button";
            this.b0Button.Size = new System.Drawing.Size(24, 20);
            this.b0Button.TabIndex = 18;
            this.b0Button.Text = "0";
            this.b0Button.UseVisualStyleBackColor = true;
            this.b0Button.Click += new System.EventHandler(this.b0Button_Click);
            // 
            // b1Button
            // 
            this.b1Button.Location = new System.Drawing.Point(109, 64);
            this.b1Button.Name = "b1Button";
            this.b1Button.Size = new System.Drawing.Size(21, 23);
            this.b1Button.TabIndex = 19;
            this.b1Button.Text = "1";
            this.b1Button.UseVisualStyleBackColor = true;
            this.b1Button.Click += new System.EventHandler(this.b1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 205);
            this.Controls.Add(this.b1Button);
            this.Controls.Add(this.b0Button);
            this.Controls.Add(this.a1Button);
            this.Controls.Add(this.a0Button);
            this.Controls.Add(this.characterNumericUpDown);
            this.Controls.Add(this.xorLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.andLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Application Bit String";
            ((System.ComponentModel.ISupportInitialize)(this.characterNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label andLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label xorLabel;
        private System.Windows.Forms.NumericUpDown characterNumericUpDown;
        private System.Windows.Forms.Button a0Button;
        private System.Windows.Forms.Button a1Button;
        private System.Windows.Forms.Button b0Button;
        private System.Windows.Forms.Button b1Button;
    }
}

