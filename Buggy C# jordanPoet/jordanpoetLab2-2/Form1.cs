using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jordanpoetLab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBut_Click(object sender, EventArgs e)
        {
            try
            {
                //decimal for original Price isn't working correctly
                //tipLabel won't go toString
                decimal originalPrice = decimal(priceText.Text);
                decimal tip = (originalPrice * (decimal).15);
                decimal tax = (originalPrice * (decimal).07);
                decimal totalPrice = (originalPrice + tip + tax);
                tipLabel.Text = tip.ToString(C");
                taxLabel.Text = tax.ToString("C");
                totalLabel.Text = totalPrice.ToString("C");
            }
                //Message isn't displaying correctly
            catch (Exception ex)
            {
                MessageBox.Show(e.Message);
            }
        
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
