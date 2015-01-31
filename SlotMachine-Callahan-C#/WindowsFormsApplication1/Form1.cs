using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**************************************************************************************
 *  Rob Callahan's Simple Slot Machine.
 * 
 * Bugs in the code:
 * 1. the middle picture continues to spin without stopping  
 * 2. The game always shows a win because the testing code is not commented out
 * 3. The third picture never displays a lemon
 **************************************************************************************/
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int handleTime = 1;
        int pic1Count = 0;
        int pic2Count = 0;
        int pic3Count = 0;
        int image1, image2, image3;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void handleUpPictureBox_Click(object sender, EventArgs e)
        {
            handleUpPictureBox.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            label1.Text="";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            handleTime++;
            if(handleTime>7)
            {
                handleUpPictureBox.Visible = true;
                handleTime = 1;
                timer1.Enabled = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pic1Count++;
            image1 = rand.Next(4);
            switch (image1)
            {
                case 0: pictureBox1.Image = Cherry.Image;
                    break;
                case 1: pictureBox1.Image = Banana.Image;
                    break;
                case 2: pictureBox1.Image = Apple.Image;
                    break;
                default:pictureBox1.Image = Lemon.Image;
                    break;
           }
            if (pic1Count > 15)
            {
                pic1Count = 0;
                timer2.Enabled = false;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pic2Count++;
            image2 = rand.Next(4);
            switch (image2)
            {
                case 0: pictureBox2.Image = Cherry.Image;
                    break;
                case 1: pictureBox2.Image = Banana.Image;
                    break;
                case 2: pictureBox2.Image = Apple.Image;
                    break;
                default:pictureBox2.Image = Lemon.Image;
                    break;
            }
            if (pic1Count > 30)                              //ERROR  - The condition statment is checking the wrong object    
            {
                pic2Count = 0;
                timer3.Enabled = false;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            pic3Count++;
            image3 = rand.Next(3);                          //ERROR  - Random number parameter is incorrect
            switch (image3)
            {
                case 0: pictureBox3.Image = Cherry.Image;
                    break;
                case 1: pictureBox3.Image = Banana.Image;
                    break;
                case 2: pictureBox3.Image = Apple.Image;
                    break;
                default:pictureBox3.Image = Lemon.Image;
                    break;
            }
            if (pic3Count > 40)
            {
                pic3Count = 0;
                timer4.Enabled = false;
                image1 = 1;     //used for testing a win        // ERROR  These need to be commented out or deleted after testing
                image2 = 1;     //used for testing a win        // ERROR  These need to be commented out or deleted after testing
                image3 = 1;     //used for testing a win        // ERROR  These need to be commented out or deleted after testing
                checkForWin();
            }
        }
        private void checkForWin()
        {
            if (image1==image2 & image2==image3)
               label1.Text = "You Win!";
            else
               label1.Text = "You Loose";
        }

        
    }
}
