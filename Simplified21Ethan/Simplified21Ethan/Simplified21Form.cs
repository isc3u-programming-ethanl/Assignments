/*
 * Created by: Ethan L
 * Created on: 11/04/19
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This program is a simplified version of 21. It is you VS the computer and whoever is closest or equal to 21 wins. If someone goes over 21, they bust (lose) the game. 
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

namespace Simplified21Ethan
{
    public partial class frmSimplified21 : Form
    {
        List<Image> listOfCardImages = new List<Image>();
        List<int> listOfCardValues = new List<int>();

        const int MIN_VALUE = 1;
        const int MAX_VALUE = 11;

        Random randomNumberGenerator;
        int playerTotal = 0;
        int dealerTotal = 0;
        int card1;
        int card2;
        int card3;
        int dealerCard1;
        int dealerCard2;
        int dealerCard3;

        public frmSimplified21()
        {
            InitializeComponent();

            // create the random number generator object
            randomNumberGenerator = new Random();

        }

        private void FrmSimplified21_Load(object sender, EventArgs e)
        {
            // make things visible and invisible
            this.lblPlayerCard1.Visible = true;
            this.lblPlayerCard2.Visible = true;
            this.lblPlayerCard3.Visible = false;
            this.lblDealerCard1.Visible = true;
            this.lblDealerCard2.Visible = true;
            this.lblDealerCard3.Visible = true;
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.lblPlayerTotal.Visible = true;
            this.lblDealerTotal.Visible = true;
            this.btnHit.Visible = true;
            this.btnStay.Visible = true;
            this.btnStay.Enabled = false;
            this.btnHit.Enabled = false;

            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2D;
            listOfCardImages[0] = Properties.Resources._2H;
            listOfCardImages[0] = Properties.Resources._2S;
            listOfCardImages[0] = Properties.Resources._3C;
            listOfCardImages[0] = Properties.Resources._3D;
            listOfCardImages[0] = Properties.Resources._3H;
            listOfCardImages[0] = Properties.Resources._3S;
            listOfCardImages[0] = Properties.Resources._4C;
            listOfCardImages[0] = Properties.Resources._4D;
            listOfCardImages[0] = Properties.Resources._4H;
            listOfCardImages[0] = Properties.Resources._4S;
            listOfCardImages[0] = Properties.Resources._5C;
            listOfCardImages[0] = Properties.Resources._5D;
            listOfCardImages[0] = Properties.Resources._5H;
            listOfCardImages[0] = Properties.Resources._5S;
            listOfCardImages[0] = Properties.Resources._6C;
            listOfCardImages[0] = Properties.Resources._6D;
            listOfCardImages[0] = Properties.Resources._6H;
            listOfCardImages[0] = Properties.Resources._6S;
            listOfCardImages[0] = Properties.Resources._7C;
            listOfCardImages[0] = Properties.Resources._7D;
            listOfCardImages[0] = Properties.Resources._7H;
            listOfCardImages[0] = Properties.Resources._7S;
            listOfCardImages[0] = Properties.Resources._8C;
            listOfCardImages[0] = Properties.Resources._8D;
            listOfCardImages[0] = Properties.Resources._8H;
            listOfCardImages[0] = Properties.Resources._8S;
            listOfCardImages[0] = Properties.Resources._9C;
            listOfCardImages[0] = Properties.Resources._9D;
            listOfCardImages[0] = Properties.Resources._9H;
            listOfCardImages[0] = Properties.Resources._9S;
            listOfCardImages[0] = Properties.Resources._10C;
            listOfCardImages[0] = Properties.Resources._10D;
            listOfCardImages[0] = Properties.Resources._10H;
            listOfCardImages[0] = Properties.Resources._10S;
            listOfCardImages[0] = Properties.Resources.AC;
            listOfCardImages[0] = Properties.Resources.AD;
            listOfCardImages[0] = Properties.Resources.AH;
            listOfCardImages[0] = Properties.Resources.AS;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;
            listOfCardImages[0] = Properties.Resources._2C;


        }
        private int DealCard(ref PictureBox pic, int randomIndex)
        {
            // Declare local variables
            int cardValue;
            Image card;

            randomIndex = randomNumberGenerator.Next(0, listOfCardValues.Count() + 1);

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picPlayerCard1.Image = card;
            picPlayerCard2.Image = card;
            picPlayerCard3.Image = card;
            picDealerCard1.Image = card;
            picDealerCard2.Image = card;
            picDealerCard3.Image = card;

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            cardValue = listOfCardValues[randomIndex];

            // Remove value from listOfValues
            listOfCardValues.RemoveAt(randomIndex);

            // Return cardValue
            return cardValue;

        }
        private void BtnStay_Click(object sender, EventArgs e)
        {
            // call the declareWinner function
            declareWinner();
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            // declare card3's value
            card3 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            // set the new player total to all cards added up (c1 + c2 + c3)
            playerTotal = card1 + card2 + card3;
            // Set the playerCard3 text to a string
            this.lblPlayerCard3.Text = Convert.ToString(card3);
            // Set the playerTotal text to a string
            this.lblPlayerTotal.Text = Convert.ToString(playerTotal);
            // Make the 3rd player card visible
            this.lblPlayerCard3.Visible = true;

            // call the declareWinner function
            declareWinner();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            // get the random generated player card numbers
            card1 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            card2 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // get the random generated dealer card numbers
            dealerCard1 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            dealerCard2 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            dealerCard3 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set the totals for player and dealer
            playerTotal = card1 + card2;
            dealerTotal = dealerCard1 + dealerCard2 + dealerCard3;

            // Set the playerCard1 and 2 text to a string
            this.lblPlayerCard1.Text = Convert.ToString(card1);
            this.lblPlayerCard2.Text = Convert.ToString(card2);

            // Set the dealer card text to all unknown to the player
            this.lblDealerCard1.Text = "???";
            this.lblDealerCard2.Text = "???";
            this.lblDealerCard3.Text = "???";

            // Show the player total and make the dealer total unknown to the player
            this.lblPlayerTotal.Text = Convert.ToString(playerTotal);
            this.lblDealerTotal.Text = "???";

            // Enable the hit and stay buttons
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;

            // Hide all the labels (win, lose, tie, playerCard3)
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.lblPlayerCard3.Visible = false;

        }

        private void declareWinner()
        {
            // determine winner
            if (playerTotal == dealerTotal)
            {
                this.lblYouTie.Visible = true;
            }
            else if (dealerTotal > 21)
            {
                this.lblYouWin.Visible = true;
            }
            else if (playerTotal > 21)
            {
                this.lblYouLose.Visible = true;
            }
            else if (playerTotal > dealerTotal)
            {
                this.lblYouWin.Visible = true;
            }
            else
            {
                this.lblYouLose.Visible = true;
            }

            // display dealer results
            this.lblDealerCard1.Text = Convert.ToString(dealerCard1);
            this.lblDealerCard2.Text = Convert.ToString(dealerCard2);
            this.lblDealerCard3.Text = Convert.ToString(dealerCard3);

            this.lblPlayerTotal.Text = Convert.ToString(playerTotal);
            this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

            // disable buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;
        }
    }
}
