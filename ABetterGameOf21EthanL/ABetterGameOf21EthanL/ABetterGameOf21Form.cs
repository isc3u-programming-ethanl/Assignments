using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABetterGameOf21EthanL
{
    public partial class frmABetterGameOf21 : Form
    {
        List<Image> listOfCardImages = new List<Image>();
        List<int> listOfCardValues = new List<int>();
        int[] totalCardValue = new int[MAX_ARRAY_SIZE];
        int[] totalDealerCardValue = new int[MAX_ARRAY_SIZE];


        const int MIN_VALUE = 1;
        const int MAX_VALUE = 11;
        const int MAX_ARRAY_SIZE = 3;

        Random randomNumberGenerator;
 
        public frmABetterGameOf21()
        {
            InitializeComponent();

            // create the random number generator object
            randomNumberGenerator = new Random();
        }
        
        private void NewDeck()
        {
            listOfCardImages.Clear();
            listOfCardValues.Clear();

            this.picPlayerCard1.Image = Properties.Resources.red_back;
            this.picPlayerCard2.Image = Properties.Resources.red_back;
            this.picPlayerCard3.Image = Properties.Resources.red_back;
            this.picDealerCard1.Image = Properties.Resources.red_back;
            this.picDealerCard2.Image = Properties.Resources.red_back;
            this.picDealerCard3.Image = Properties.Resources.red_back;
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.lblPlayerTotal.Text = "???";
            this.lblDealerTotal.Text = "???";
            this.picPlayerCard3.Visible = false;


            listOfCardImages.Add(Properties.Resources._2C);
            listOfCardImages.Add(Properties.Resources._2D);
            listOfCardImages.Add(Properties.Resources._2H);
            listOfCardImages.Add(Properties.Resources._2S);
            listOfCardImages.Add(Properties.Resources._3C);
            listOfCardImages.Add(Properties.Resources._3D);
            listOfCardImages.Add(Properties.Resources._3H);
            listOfCardImages.Add(Properties.Resources._3S);
            listOfCardImages.Add(Properties.Resources._4C);
            listOfCardImages.Add(Properties.Resources._4D);
            listOfCardImages.Add(Properties.Resources._4H);
            listOfCardImages.Add(Properties.Resources._4S);
            listOfCardImages.Add(Properties.Resources._5C);
            listOfCardImages.Add(Properties.Resources._5D);
            listOfCardImages.Add(Properties.Resources._5H);
            listOfCardImages.Add(Properties.Resources._5S);
            listOfCardImages.Add(Properties.Resources._6C);
            listOfCardImages.Add(Properties.Resources._6D);
            listOfCardImages.Add(Properties.Resources._6H);
            listOfCardImages.Add(Properties.Resources._6S);
            listOfCardImages.Add(Properties.Resources._7C);
            listOfCardImages.Add(Properties.Resources._7D);
            listOfCardImages.Add(Properties.Resources._7H);
            listOfCardImages.Add(Properties.Resources._7S);
            listOfCardImages.Add(Properties.Resources._8C);
            listOfCardImages.Add(Properties.Resources._8D);
            listOfCardImages.Add(Properties.Resources._8H);
            listOfCardImages.Add(Properties.Resources._8S);
            listOfCardImages.Add(Properties.Resources._9C);
            listOfCardImages.Add(Properties.Resources._9D);
            listOfCardImages.Add(Properties.Resources._9H);
            listOfCardImages.Add(Properties.Resources._9S);
            listOfCardImages.Add(Properties.Resources._10C);
            listOfCardImages.Add(Properties.Resources._10D);
            listOfCardImages.Add(Properties.Resources._10H);
            listOfCardImages.Add(Properties.Resources._10S);
            listOfCardImages.Add(Properties.Resources.AC);
            listOfCardImages.Add(Properties.Resources.AD);
            listOfCardImages.Add(Properties.Resources.AH);
            listOfCardImages.Add(Properties.Resources.AS);
            listOfCardImages.Add(Properties.Resources.JC);
            listOfCardImages.Add(Properties.Resources.JD);
            listOfCardImages.Add(Properties.Resources.JH);
            listOfCardImages.Add(Properties.Resources.JS);
            listOfCardImages.Add(Properties.Resources.KC);
            listOfCardImages.Add(Properties.Resources.KD);
            listOfCardImages.Add(Properties.Resources.KH);
            listOfCardImages.Add(Properties.Resources.KS);
            listOfCardImages.Add(Properties.Resources.QC);
            listOfCardImages.Add(Properties.Resources.QD);
            listOfCardImages.Add(Properties.Resources.QH);
            listOfCardImages.Add(Properties.Resources.QS);

            listOfCardValues.Add(2);
            listOfCardValues.Add(2);
            listOfCardValues.Add(2);
            listOfCardValues.Add(2);
            listOfCardValues.Add(3);
            listOfCardValues.Add(3);
            listOfCardValues.Add(3);
            listOfCardValues.Add(3);
            listOfCardValues.Add(4);
            listOfCardValues.Add(4);
            listOfCardValues.Add(4);
            listOfCardValues.Add(4);
            listOfCardValues.Add(5);
            listOfCardValues.Add(5);
            listOfCardValues.Add(5);
            listOfCardValues.Add(5);
            listOfCardValues.Add(6);
            listOfCardValues.Add(6);
            listOfCardValues.Add(6);
            listOfCardValues.Add(6);
            listOfCardValues.Add(7);
            listOfCardValues.Add(7);
            listOfCardValues.Add(7);
            listOfCardValues.Add(7);
            listOfCardValues.Add(8);
            listOfCardValues.Add(8);
            listOfCardValues.Add(8);
            listOfCardValues.Add(8);
            listOfCardValues.Add(9);
            listOfCardValues.Add(9);
            listOfCardValues.Add(9);
            listOfCardValues.Add(9);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(1);
            listOfCardValues.Add(1);
            listOfCardValues.Add(1);
            listOfCardValues.Add(1); 
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);
            listOfCardValues.Add(10);

            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();

        }
        private int DealCard(ref PictureBox picPlayerCard1, int randomIndex)
        {
            // Declare local variables
            int cardValue;
            Image card;
            randomIndex = randomNumberGenerator.Next(0, listOfCardValues.Count());

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picPlayerCard1.Image = card;

            // Update the card total label
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            cardValue = listOfCardValues[randomIndex];

            // Remove value from listOfValues
            listOfCardValues.RemoveAt(randomIndex);

            // add the card value to the card total list
            totalCardValue[0] = cardValue;
            
            // Return cardValue
            return cardValue;

        }
        private int DealCard2(ref PictureBox picPlayerCard2, int randomIndex)
        {
            // Declare local variables
            int cardValue2;
            Image card;
            randomIndex = randomNumberGenerator.Next(0, listOfCardValues.Count());

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picPlayerCard2.Image = card;

            // Update the card total label
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            cardValue2 = listOfCardValues[randomIndex];

            // Remove value from listOfValues
            listOfCardValues.RemoveAt(randomIndex);

            // add the card value to the card total list
            totalCardValue[1] = cardValue2;

            // Return cardValue
            return cardValue2;

        }
        private int DealCard3(ref PictureBox picPlayerCard3, int randomIndex)
        {
            // Declare local variables
            int cardValue;
            Image card;
            randomIndex = randomNumberGenerator.Next(0, listOfCardValues.Count());

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picPlayerCard3.Image = card;

            // Update the card total label
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            cardValue = listOfCardValues[randomIndex];

            // Remove value from listOfValues
            listOfCardValues.RemoveAt(randomIndex);

            // add the card value to the card total list
            totalCardValue[2] = cardValue;

            // Return cardValue
            return cardValue;

        }
        private int DealerDealCard(ref PictureBox picDealerCard3, int randomIndex)
        {
            // Declare local variables
            int dealerCardValue;
            Image card;
            randomIndex = randomNumberGenerator.Next(0, listOfCardValues.Count());

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picDealerCard1.Image = card;

            // Update the card total label
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            dealerCardValue = listOfCardValues[randomIndex];

            // Remove value from listOfValues
            listOfCardValues.RemoveAt(randomIndex);

            // add the card value to the card total list
            totalDealerCardValue[0] = dealerCardValue;

            // Return cardValue
            return dealerCardValue;

        }
        private int DealerDealCard2(ref PictureBox picDealerCard2, int randomIndex)
        {
            // Declare local variables
            int dealerCardValue2;
            Image card;
            randomIndex = randomNumberGenerator.Next(0, listOfCardValues.Count());

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picDealerCard2.Image = card;

            // Update the card total label
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            dealerCardValue2 = listOfCardValues[randomIndex];

            // Remove value from listOfValues
            listOfCardValues.RemoveAt(randomIndex);

            // add the card value to the card total list
            totalDealerCardValue[1] = dealerCardValue2;

            // Return cardValue
            return dealerCardValue2;

        }
        private int DealerDealCard3(ref PictureBox picDealerCard3, int randomIndex)
        {
            // Declare local variables
            int dealerCardValue3;
            Image card;
            randomIndex = randomNumberGenerator.Next(0, listOfCardValues.Count());

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picDealerCard3.Image = card;

            // Update the card total label
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            dealerCardValue3 = listOfCardValues[randomIndex];

            // Remove value from listOfValues
            listOfCardValues.RemoveAt(randomIndex);

            // add the card value to the card total list
            totalDealerCardValue[2] = dealerCardValue3;

            // Return cardValue
            return dealerCardValue3;

        }


        private void FrmABetterGameOf21_Load(object sender, EventArgs e)
        {
            // make things visible and invisible
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.lblPlayerTotal.Visible = true;
            this.lblDealerTotal.Visible = true;
            this.btnHit.Visible = true;
            this.btnStay.Visible = true;
            this.btnStay.Enabled = false;
            this.btnHit.Enabled = false;
            this.picPlayerCard3.Visible = false;

            // Call the NewDeck function when the form loads
            NewDeck();
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            int card1 = 0;
            int card2 = 0;
            int card3 = 0;

            DealCard(ref picPlayerCard1, card1);
            DealCard2(ref picPlayerCard2, card2);
            DealerDealCard(ref picDealerCard1, card1);
            DealerDealCard2(ref picDealerCard2, card2);
            DealerDealCard3(ref picDealerCard3, card3);

            this.picPlayerCard3.Visible = false;


            // call the declareWinner function
            declareWinner();
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            int card1 = 0;
            int card2 = 0;
            int card3 = 0;

            this.picPlayerCard3.Visible = true;


            DealCard(ref picPlayerCard1, card1);
            DealCard2(ref picPlayerCard2, card2);
            DealCard3(ref picPlayerCard3, card3);
            DealerDealCard(ref picDealerCard1, card1);
            DealerDealCard2(ref picDealerCard2, card2);
            DealerDealCard3(ref picDealerCard3, card3);

            // call the declareWinner function
            declareWinner();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

            // Set the dealer card text to all unknown to the player
            this.picPlayerCard1.Image = Properties.Resources.red_back;
            this.picPlayerCard2.Image = Properties.Resources.red_back;
            this.picDealerCard1.Image = Properties.Resources.red_back;
            this.picDealerCard2.Image = Properties.Resources.red_back;
            this.picDealerCard3.Image = Properties.Resources.red_back;

            this.lblPlayerTotal.Text = "???";
            this.lblDealerTotal.Text = "???";

            // Enable the hit and stay buttons
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;

            // Hide all the labels (win, lose, tie, playerCard3)
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.picPlayerCard3.Visible = false;

        }

        private void declareWinner()
        {
            int cardTotal;
            int dealerCardTotal;
            cardTotal = totalCardValue[0] + totalCardValue[1] + totalCardValue[2];
            dealerCardTotal = totalDealerCardValue[0] + totalDealerCardValue[1] + totalDealerCardValue[2];

            this.lblPlayerTotal.Text = "Player Card Total: " + cardTotal;
            this.lblDealerTotal.Text = "Dealer Card Total: " + dealerCardTotal;

            // determine winner
            if (cardTotal == dealerCardTotal)
            {
                this.lblYouTie.Visible = true;
            }
            else if (dealerCardTotal > 21)
            {
                this.lblYouWin.Visible = true;
            }
            else if (cardTotal > 21)
            {
                this.lblYouLose.Visible = true;
            }
            else if (cardTotal > dealerCardTotal)
            {
                this.lblYouWin.Visible = true;
            }
            else
            {
                this.lblYouLose.Visible = true;
            }

            if (listOfCardImages.Count() < 6)
            {
                MessageBox.Show("You ran out of cards. Reshuffling deck!", "Error");

                NewDeck();


            }
            // disable buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;
        }
    }
}
