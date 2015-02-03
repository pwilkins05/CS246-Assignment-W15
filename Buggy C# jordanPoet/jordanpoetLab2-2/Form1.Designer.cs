namespace jordanpoetLab2_2
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
            this.priceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.calculateBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(350, 45);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 20);
            this.priceText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the cost of meal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total";
            // 
            // tipLabel
            // 
            this.tipLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tipLabel.Location = new System.Drawing.Point(350, 80);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(100, 23);
            this.tipLabel.TabIndex = 5;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(350, 159);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 6;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxLabel.Location = new System.Drawing.Point(350, 119);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 7;
            // 
            // calculateBut
            // 
            this.calculateBut.Location = new System.Drawing.Point(104, 200);
            this.calculateBut.Name = "calculateBut";
            this.calculateBut.Size = new System.Drawing.Size(182, 23);
            this.calculateBut.TabIndex = 8;
            this.calculateBut.Text = "Click to calculate your meal cost";
            this.calculateBut.UseVisualStyleBackColor = true;
            this.calculateBut.Click += new System.EventHandler(this.calculateBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 261);
            this.Controls.Add(this.calculateBut);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Button calculateBut;
    }
}

