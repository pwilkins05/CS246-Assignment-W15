using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numLabel.Text = "Click a button";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            numLabel.Text = "One";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numLabel.Text = "Two";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numLabel.Text = "Three";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            numLabel.Text = "Four";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            numLabel.Text = "Five";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numLabel.Text = "Goodbye";
            System.Threading.Thread.Sleep(1500);

            this.Close();
        }
    }
}
