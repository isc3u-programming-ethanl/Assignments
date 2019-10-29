/*
 * Created by: Ethan L
 * Created on: 10/10/19
 * Created for: ICS3U Programming
 * Assignment #4b - Pizza Order
 * This program allows the user to enter the pizza type they want, and the amount of toppings they want.
 * The computer calculates how much the total is including the 13% HST
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

namespace PizzaOrderEthan
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void FrmPizzaOrder_Load(object sender, EventArgs e)
        {

        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void LblSelectSizeText_Click(object sender, EventArgs e)
        {

        }

        private void NupTypePizza_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblLargePizzaText_Click(object sender, EventArgs e)
        {

        }

        private void LblExtraLargePizzaText_Click(object sender, EventArgs e)
        {

        }

        private void LblToppingsChoiceText_Click(object sender, EventArgs e)
        {

        }

        private void NupToppingsChoice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblSubtotalText_Click(object sender, EventArgs e)
        {

        }

        private void LblPstText_Click(object sender, EventArgs e)
        {

        }

        private void LblGSTText_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalText_Click(object sender, EventArgs e)
        {

        }

        private void LblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void LblPST_Click(object sender, EventArgs e)
        {

        }

        private void LblHST_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            const double smallPizzaSize = 4.99;
            const double mediumPizzaSize = 6.99;
            const double largePizzaSize = 9.99;
            const double extraLargePizzaSize = 12.99;
            const double toppings0 = 0;
            const double toppings1 = 0.75;
            const double toppings2 = 1.35;
            const double toppings3 = 2.15;
            const double toppings4 = 2.75;
  
            double subtotal, total, userChoicePizza, userChoiceToppings, HST;

            userChoicePizza = double.Parse(nupTypePizza.Text);
            userChoiceToppings = double.Parse(nupToppingsChoice.Text);

            subtotal = userChoicePizza + userChoiceToppings;

            if (userChoicePizza == 1)
            {
                subtotal = smallPizzaSize;
            }

            else if (userChoicePizza == 2)
            {
                subtotal = mediumPizzaSize;
            }

            else if (userChoicePizza == 3)
            {
                subtotal = largePizzaSize;
            }

            else if (userChoicePizza == 4)
            {
                subtotal = extraLargePizzaSize;
            }

            if (userChoiceToppings == 0)
            {
                subtotal = subtotal + toppings0;
            }

            else if (userChoiceToppings == 1)
            {
                subtotal = subtotal + toppings1;
            }

            else if (userChoiceToppings == 2)
            {
                subtotal = subtotal + toppings2;
            }

            else if (userChoiceToppings == 3)
            {
                subtotal = subtotal + toppings3;
            }

            else
            {
                subtotal = subtotal + toppings4;
            }

            HST = subtotal * 0.13;
            total = subtotal + HST;

            lblSubtotal.Text = String.Format("${0:0.00}", subtotal);
            lblHST.Text = String.Format("${0:0.00}", HST);
            lblTotal.Text = String.Format("${0:0.00}", total);


        }
    }
}
