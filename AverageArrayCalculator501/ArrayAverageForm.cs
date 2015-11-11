/*
 * Created by: Nicholas  Ellul
 * Created on: 11-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-01
 * This program adds nuumbers 1 though 10, then says average of numbers.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageArrayCalculator501
{
    public partial class ArrayAverageForm : Form
    {
        //global declaration
        int[] arrayOfNumbers = new int[10];
        Random randomNumbers = new Random();

       
        public ArrayAverageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            //input
            const int NUMBER_OF_ITEMS = 10;
            int randomizedNumber;

            //process
            this.lstArrayNumbers.Items.Clear();

            for (int counter = 0; counter < NUMBER_OF_ITEMS; counter++)
            {
                randomizedNumber = randomNumbers.Next(1, 10 + 1);
                this.lstArrayNumbers.Items.Add(randomizedNumber);
                arrayOfNumbers[counter] = randomizedNumber;
            }

            //output
            this.lblAverage.Text = "The average is: " + arrayOfNumbers.Sum()/NUMBER_OF_ITEMS;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
