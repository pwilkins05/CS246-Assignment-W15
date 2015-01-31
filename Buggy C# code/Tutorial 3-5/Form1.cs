using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_5
{
    public partial class changeCounter : Form
    {
        double total;

        public changeCounter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // FIXED
        }

        private void fiveCentPictureBox_Click(object sender, EventArgs e)
        {
            total += .05; // numerical error FIXED
            totalDisplayLabel.Text = total.ToString("c");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += .10;
            totalDisplayLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += .25;
            totalDisplayLabel.Text = total.ToString("c");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += .50;
            totalDisplayLabel.Text = total.ToString("c"); // incorrect format FIXED
        }
    }
}
