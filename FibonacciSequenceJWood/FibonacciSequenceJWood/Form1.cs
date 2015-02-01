using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciSequenceJWood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Bug Fixes: 
         *          if statement for input check (numbers ranged 2-20).
                    Fixed typo in foreach loop.
         */         

        private void fibButton_Click(object sender, EventArgs e)
        {
            int startNum = 1;  // Starting number
            int endNum = int.Parse(endNumBox.Text);  // Set end number to the input in textbox

            if (endNum <= 20 && endNum >= 2)
            {
                fibListBox.Items.Clear();  // Refresh listbox on new button click              

                int[] fibonaccciArray = new int[30];  // Array to hold the sequence


                /* This loop will simply set the first two elements to the starting number
                 *  and add them to the listbox.  This is why the endNum must be atleast 2 */
                for (int index = 0; index < 2; index++) 
                {
                    fibonaccciArray[index] = startNum;
                    fibListBox.Items.Add(fibonaccciArray[index]);
                }


                /* This loop will start at the 3rd element since the first two elements are predetermined,
                 * and then it will add together the previous two elements, and then add the current one
                 * to the listbox */
                for (int index = 2; index < endNum; index++)  
                {
                    fibonaccciArray[index] = fibonaccciArray[index - 1] + fibonaccciArray[index - 2];   
                    fibListBox.Items.Add(fibonaccciArray[index]); 
                }
            }
            else
                MessageBox.Show("Please enter a number between 1 and 20");  // Show a message if the input number is out of set range
        }
    }
}
