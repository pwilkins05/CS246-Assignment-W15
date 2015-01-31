namespace FibonacciSequenceJWood
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
            this.fibButton = new System.Windows.Forms.Button();
            this.fibListBox = new System.Windows.Forms.ListBox();
            this.endNumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fibButton
            // 
            this.fibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibButton.Location = new System.Drawing.Point(210, 191);
            this.fibButton.Name = "fibButton";
            this.fibButton.Size = new System.Drawing.Size(220, 101);
            this.fibButton.TabIndex = 0;
            this.fibButton.Text = "Show Fibonacci Sequence";
            this.fibButton.UseVisualStyleBackColor = true;
            this.fibButton.Click += new System.EventHandler(this.fibButton_Click);
            // 
            // fibListBox
            // 
            this.fibListBox.FormattingEnabled = true;
            this.fibListBox.ItemHeight = 16;
            this.fibListBox.Location = new System.Drawing.Point(210, 331);
            this.fibListBox.Name = "fibListBox";
            this.fibListBox.Size = new System.Drawing.Size(220, 148);
            this.fibListBox.TabIndex = 1;
            // 
            // endNumBox
            // 
            this.endNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endNumBox.Location = new System.Drawing.Point(539, 295);
            this.endNumBox.Name = "endNumBox";
            this.endNumBox.Size = new System.Drawing.Size(55, 30);
            this.endNumBox.TabIndex = 2;
            this.endNumBox.Text = "20";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 89);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many elements would you like the Fibonacci Sequence to be? (Pick between 2 - " +
    "20):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(718, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "A Fibonacci Sequence is basically the sum of the previous two numbers...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endNumBox);
            this.Controls.Add(this.fibListBox);
            this.Controls.Add(this.fibButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fibButton;
        private System.Windows.Forms.ListBox fibListBox;
        private System.Windows.Forms.TextBox endNumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

