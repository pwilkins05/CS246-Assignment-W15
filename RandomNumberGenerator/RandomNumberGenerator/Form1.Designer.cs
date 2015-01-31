namespace RandomNumberGenerator
{
    partial class RNG
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
            this.RNGTB = new System.Windows.Forms.TextBox();
            this.GenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate random nubers between 1 and 100!";
            // 
            // RNGTB
            // 
            this.RNGTB.Enabled = false;
            this.RNGTB.Location = new System.Drawing.Point(103, 73);
            this.RNGTB.Name = "RNGTB";
            this.RNGTB.Size = new System.Drawing.Size(100, 20);
            this.RNGTB.TabIndex = 1;
            this.RNGTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(113, 137);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(75, 23);
            this.GenButton.TabIndex = 2;
            this.GenButton.Text = "Generate!";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // RNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 193);
            this.Controls.Add(this.GenButton);
            this.Controls.Add(this.RNGTB);
            this.Controls.Add(this.label1);
            this.Name = "RNG";
            this.Text = "RNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RNGTB;
        private System.Windows.Forms.Button GenButton;
    }
}

