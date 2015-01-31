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
            numLabel.Text = "Hello";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //typo in the string
            numLabel.Text = "Goodbye";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numLabel.Text = "Two";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //wrong string here
            numLabel.Text = "Two";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // wrong string here
            numLabel.Text = "One";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //mistake
            numLabell.Text = "Five";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //should be 1500 not 15000
            numLabel.Text = "Goodbye";
            System.Threading.Thread.Sleep(15000);

            this.Close();
        }
    }
}
