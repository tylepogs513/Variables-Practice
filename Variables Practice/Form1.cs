using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string name = "Wayne Gretzky";
            int number = 99;
            display.Text = (name + " is number " + number + ".");
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double numberOne, numberTwo;
            int radius = 15;

            numberOne = 706.858347057703;
            display.Text = ("The area of a circle with the " +
                "\nradius of " + radius + " is " + numberOne + "cm^2.");
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double numberOne, numberTwo, numberThree, numberFour, numberFive;

            numberOne = 8.5;
            numberTwo = 6;
            numberThree = 15;
            numberFour = 19.95;
            numberFive = 1017.45;

            display.Text = "The area of a room with dimensions \n" + numberOne +
                "m x " + numberTwo + "m is " + numberThree + "m^2." +
                "\n\nThe cost to carpet this area at " + numberFour +
                "\nper sqaure metre is " + numberFive;
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double numberOne, numberTwo, numberThree, numberFour, numberFive;

            numberOne = 12.49;
            numberTwo = 1.62;
            numberThree = 14.11;
            numberFour = 20;
            numberFive = 5.89;

            display.Text = "Bill of Sale \n\nShirt:                      $" + numberOne
                + "\n\nTax:                        $ " + numberTwo
                + "\nTotal:                      $" + numberThree
                + "\n\nTendered:                   $" + numberFour + ".00"
                + "\nChange:                     $ " + numberFive;
        }
    }
}
