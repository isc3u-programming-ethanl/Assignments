/*
 * Created by: Ethan L
 * Created on: 09/20/19
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program calculates the distance of an object falling off a cliff
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

namespace FallingObjectsEthan
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void LblInputText_Click(object sender, EventArgs e)
        {

        }

        private void TxtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double time, height;

            // convert the string from each text box to a double
            time = double.Parse(txtTime.Text);

            // calculate the circumference
            height = 100 - 0.5 * 9.8 * Math.Pow(time,2);

            // insert the circumference into the respective label
            this.lblOutput.Text = Convert.ToString(height) + " meters";

            // display the circumference label with the respective answer
            this.lblOutput.Show();
        }

        private void LblOutput_Click(object sender, EventArgs e)
        {

        }

        private void LblAnswerText_Click(object sender, EventArgs e)
        {

        }

        private void FrmFallingObjects_Load(object sender, EventArgs e)
        {
            this.lblOutput.Hide();
        }
    }
}
