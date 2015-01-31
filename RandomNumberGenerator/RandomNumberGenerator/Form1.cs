using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class RNG : Form
    {

        public RNG()
        {
            InitializeComponent();
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            var r = new Random();
            // This seems to return 0, and will not reach 100.
            RNGTB.Text = r.Next(100).ToString();
        }
    }
}
