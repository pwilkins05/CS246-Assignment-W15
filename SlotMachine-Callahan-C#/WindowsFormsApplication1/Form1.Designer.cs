namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.handleUpPictureBox = new System.Windows.Forms.PictureBox();
            this.handleDownPictureBox = new System.Windows.Forms.PictureBox();
            this.Apple = new System.Windows.Forms.PictureBox();
            this.Cherry = new System.Windows.Forms.PictureBox();
            this.Banana = new System.Windows.Forms.PictureBox();
            this.Lemon = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleUpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleDownPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lemon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(259, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "You Win!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.Lemon;
            this.pictureBox3.Location = new System.Drawing.Point(510, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 202);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Banana;
            this.pictureBox2.Location = new System.Drawing.Point(272, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Apple;
            this.pictureBox1.Location = new System.Drawing.Point(37, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // handleUpPictureBox
            // 
            this.handleUpPictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.SlotHandleUp;
            this.handleUpPictureBox.Location = new System.Drawing.Point(840, 22);
            this.handleUpPictureBox.Name = "handleUpPictureBox";
            this.handleUpPictureBox.Size = new System.Drawing.Size(183, 600);
            this.handleUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.handleUpPictureBox.TabIndex = 0;
            this.handleUpPictureBox.TabStop = false;
            this.handleUpPictureBox.Click += new System.EventHandler(this.handleUpPictureBox_Click);
            // 
            // handleDownPictureBox
            // 
            this.handleDownPictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.SlotHandleDown;
            this.handleDownPictureBox.Location = new System.Drawing.Point(840, 22);
            this.handleDownPictureBox.Name = "handleDownPictureBox";
            this.handleDownPictureBox.Size = new System.Drawing.Size(183, 600);
            this.handleDownPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.handleDownPictureBox.TabIndex = 1;
            this.handleDownPictureBox.TabStop = false;
            // 
            // Apple
            // 
            this.Apple.Image = global::WindowsFormsApplication1.Properties.Resources.Apple;
            this.Apple.Location = new System.Drawing.Point(318, 577);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(23, 26);
            this.Apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Apple.TabIndex = 6;
            this.Apple.TabStop = false;
            this.Apple.Visible = false;
            // 
            // Cherry
            // 
            this.Cherry.Image = global::WindowsFormsApplication1.Properties.Resources.Cherries;
            this.Cherry.Location = new System.Drawing.Point(354, 577);
            this.Cherry.Name = "Cherry";
            this.Cherry.Size = new System.Drawing.Size(23, 26);
            this.Cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Cherry.TabIndex = 6;
            this.Cherry.TabStop = false;
            this.Cherry.Visible = false;
            // 
            // Banana
            // 
            this.Banana.Image = global::WindowsFormsApplication1.Properties.Resources.Banana;
            this.Banana.Location = new System.Drawing.Point(389, 577);
            this.Banana.Name = "Banana";
            this.Banana.Size = new System.Drawing.Size(23, 26);
            this.Banana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Banana.TabIndex = 6;
            this.Banana.TabStop = false;
            this.Banana.Visible = false;
            // 
            // Lemon
            // 
            this.Lemon.Image = global::WindowsFormsApplication1.Properties.Resources.Lemon;
            this.Lemon.Location = new System.Drawing.Point(429, 577);
            this.Lemon.Name = "Lemon";
            this.Lemon.Size = new System.Drawing.Size(23, 26);
            this.Lemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Lemon.TabIndex = 6;
            this.Lemon.TabStop = false;
            this.Lemon.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 200;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 648);
            this.Controls.Add(this.Lemon);
            this.Controls.Add(this.Banana);
            this.Controls.Add(this.Cherry);
            this.Controls.Add(this.Apple);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handleUpPictureBox);
            this.Controls.Add(this.handleDownPictureBox);
            this.Name = "Form1";
            this.Text = "Simple Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleUpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleDownPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox handleUpPictureBox;
        private System.Windows.Forms.PictureBox handleDownPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Apple;
        private System.Windows.Forms.PictureBox Cherry;
        private System.Windows.Forms.PictureBox Banana;
        private System.Windows.Forms.PictureBox Lemon;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

