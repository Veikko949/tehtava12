namespace tehtava12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.A_radioButton = new System.Windows.Forms.RadioButton();
            this.B_radioButton = new System.Windows.Forms.RadioButton();
            this.C_radioButton = new System.Windows.Forms.RadioButton();
            this.D_radioButton = new System.Windows.Forms.RadioButton();
            this.kysymys_label = new System.Windows.Forms.Label();
            this.vastaus_label = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.D_radioButton);
            this.groupBox1.Controls.Add(this.C_radioButton);
            this.groupBox1.Controls.Add(this.B_radioButton);
            this.groupBox1.Controls.Add(this.A_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(322, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastasu";
            // 
            // A_radioButton
            // 
            this.A_radioButton.AutoSize = true;
            this.A_radioButton.Location = new System.Drawing.Point(7, 20);
            this.A_radioButton.Name = "A_radioButton";
            this.A_radioButton.Size = new System.Drawing.Size(32, 17);
            this.A_radioButton.TabIndex = 0;
            this.A_radioButton.TabStop = true;
            this.A_radioButton.Text = "A";
            this.A_radioButton.UseVisualStyleBackColor = true;
            // 
            // B_radioButton
            // 
            this.B_radioButton.AutoSize = true;
            this.B_radioButton.Location = new System.Drawing.Point(8, 43);
            this.B_radioButton.Name = "B_radioButton";
            this.B_radioButton.Size = new System.Drawing.Size(32, 17);
            this.B_radioButton.TabIndex = 1;
            this.B_radioButton.TabStop = true;
            this.B_radioButton.Text = "B";
            this.B_radioButton.UseVisualStyleBackColor = true;
            // 
            // C_radioButton
            // 
            this.C_radioButton.AutoSize = true;
            this.C_radioButton.Location = new System.Drawing.Point(8, 66);
            this.C_radioButton.Name = "C_radioButton";
            this.C_radioButton.Size = new System.Drawing.Size(32, 17);
            this.C_radioButton.TabIndex = 2;
            this.C_radioButton.TabStop = true;
            this.C_radioButton.Text = "C";
            this.C_radioButton.UseVisualStyleBackColor = true;
            // 
            // D_radioButton
            // 
            this.D_radioButton.AutoSize = true;
            this.D_radioButton.Location = new System.Drawing.Point(7, 89);
            this.D_radioButton.Name = "D_radioButton";
            this.D_radioButton.Size = new System.Drawing.Size(33, 17);
            this.D_radioButton.TabIndex = 3;
            this.D_radioButton.TabStop = true;
            this.D_radioButton.Text = "D";
            this.D_radioButton.UseVisualStyleBackColor = true;
            // 
            // kysymys_label
            // 
            this.kysymys_label.AutoSize = true;
            this.kysymys_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kysymys_label.Location = new System.Drawing.Point(46, 43);
            this.kysymys_label.Name = "kysymys_label";
            this.kysymys_label.Size = new System.Drawing.Size(253, 25);
            this.kysymys_label.TabIndex = 3;
            this.kysymys_label.Text = "Vastaus 1. Kysymykseen";
            // 
            // vastaus_label
            // 
            this.vastaus_label.AutoSize = true;
            this.vastaus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastaus_label.Location = new System.Drawing.Point(47, 145);
            this.vastaus_label.Name = "vastaus_label";
            this.vastaus_label.Size = new System.Drawing.Size(68, 20);
            this.vastaus_label.TabIndex = 4;
            this.vastaus_label.Text = "Vastaus";
            this.vastaus_label.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 134);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 227);
            this.Controls.Add(this.vastaus_label);
            this.Controls.Add(this.kysymys_label);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton D_radioButton;
        private System.Windows.Forms.RadioButton C_radioButton;
        private System.Windows.Forms.RadioButton B_radioButton;
        private System.Windows.Forms.RadioButton A_radioButton;
        private System.Windows.Forms.Label kysymys_label;
        private System.Windows.Forms.Label vastaus_label;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

