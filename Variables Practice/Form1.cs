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
            display.Text = name + " is number " + number + ".";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            int radius = 15;
            double pi = 3.14;

            display.Text = "The area of a circle with the " +
                "\nradius of " + radius + " is " + (radius * radius * pi) + "cm^2.";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double numberOne, numberTwo, numberThree, numberFour, numberFive;

            numberOne = 8.5;
            numberTwo = 6;
            numberThree = numberOne * numberTwo;
            numberFour = 19.95;
            numberFive = numberThree * numberFour;

            display.Text = "The area of a room with dimensions \n" + numberOne +
                "m x " + numberTwo + "m is " + numberThree + "m^2." +
                "\n\nThe cost to carpet this area at " + numberFour +
                "\nper sqaure metre is " + numberFive + ".";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double numberOne, numberTwo, numberThree, numberFour, numberFive;

            numberOne = 12.49;
            numberTwo = 0.13;
            numberThree = numberOne * numberTwo;
            numberFour = 20;
            numberFive = numberOne + numberThree;

            display.Text = "            Bill of Sale " +
                "\n\nShirt:                      $" + numberOne
                + "\n\nTax:                        $ " + ((numberOne * numberTwo) - 0.0037)
                + "\nTotal:                      $" + (numberOne + numberThree - 0.0037)
                + "\n\nTendered:                   $" + numberFour + ".00"
                + "\nChange:                     $ " + (numberFour - numberFive - 0.0063);
        }
    }
}
