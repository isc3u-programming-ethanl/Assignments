/*
 * Created by: Ethan L
 * Created on: 12/06/19
 * Created for: ICS3U Programming
 * Assignment #6b - A Better Game of 21
 * This program works in the same way as the "simplified" version of 21. 
 * Instead of the cards being numbers in labels, the cards are picture boxes which have a corresponding value to them.
 * There is a betting system which works by giving the user 100$ to start off with. They can choose to pass on betting or use the number up down and bet.
 * If you win the bet, you get the amount you betted back, so if you have $100, and bet $50. You will gain $50, and end up with $150. 
 * If you lose, you lose the amount you betted, so if you have $100, and bet $50. You will end up with $50.
 * If you bet and tie, there will be no loss or gain from the bet.
 * There is an exit menu item which has a confirmation box saying "are you sure you want to exit?". If they click OK, the program ends. If they click Cancel, it goes back to the game.
 * There is a New Game menu item which when clicked, will reset the user's balance to the base ($100). And re-stocks the deck to be 52 cards.
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

namespace ABetterGameOf21EthanL
{
    public partial class frmABetterGameOf21 : Form
    {
        // create global lists and arrays
        List<Image> listOfCardImages = new List<Image>();
        List<int> listOfCardValues = new List<int>();
        int[] totalCardValue = new int[MAX_ARRAY_SIZE];
        int[] totalDealerCardValue = new int[MAX_ARRAY_SIZE];

        // create global variables
        const int MAX_ARRAY_SIZE = 3;
        int balance = 0;
        int amountBettedOn = 0;
        int storedBalance = 0;
        int yesOrNo = 0;
        bool trueOrFalse = false;

        Random randomNumberGenerator;
 
        public frmABetterGameOf21()
        {
            InitializeComponent();

            // create the random number generator object
            randomNumberGenerator = new Random();
        }
        
        private void NewDeck()
        {
            // update the balance label to display the user's balance
            this.lblBalance.Text = "Your Balance: " + balance + "$";
            
            // clear the image and card value lists
            listOfCardImages.Clear();
            listOfCardValues.Clear();

            // set the picture boxes to the red_back picture
            this.picPlayerCard1.Image = Properties.Resources.red_back;
            this.picPlayerCard2.Image = Properties.Resources.red_back;
            this.picPlayerCard3.Image = Properties.Resources.red_back;
            this.picDealerCard1.Image = Properties.Resources.red_back;
            this.picDealerCard2.Image = Properties.Resources.red_back;
            this.picDealerCard3.Image = Properties.Resources.red_back;
            
            // make labels and the 3rd cards invisible
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.picPlayerCard3.Visible = false;
            this.picDealerCard3.Visible = false;

            // set the player and dealer total texts to "???"
            this.lblPlayerTotal.Text = "Player Card Total: ???";
            this.lblDealerTotal.Text = "Dealer Card Total: ???";

            // add the card images to the card image list
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

            // add the values to the card value list
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

            // update the cards left text
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
            this.btnBet.Enabled = false;
            this.nudBet.Enabled = false;

            // update texts
            this.lblBalance.Text = "Your Balance: ";
            this.nudBet.Text = "0";

            // Call the NewDeck function when the form loads
            NewDeck();

            // make the balance 100 when the form loads
            balance = 100;
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            // declare local variables
            int card1 = 0;
            int card2 = 0;
            int card3 = 0;

            // update the nudBet text to say "0"
            this.nudBet.Text = "0";

            // generate yesOrNo
            yesOrNo = randomNumberGenerator.Next(0, 1 + 1);

            // if yesOrNo is 0, set trueOrFalse to false. if not, set it to true
            if (yesOrNo == 0)
            {
                trueOrFalse = false;
            }
            else
            {
                trueOrFalse = true;
            }

            // if trueOrFalse is true, call only 2 player cards and the 2 dealer cards, if not, call the 2 player cards and 3 dealer cards
            if (trueOrFalse == true)
            {
                DealCard(ref picPlayerCard1, card1);
                DealCard2(ref picPlayerCard2, card2);
                DealerDealCard(ref picDealerCard1, card1);
                DealerDealCard2(ref picDealerCard2, card2);
                this.picDealerCard3.Visible = false;
            }
            else
            {
                DealCard(ref picPlayerCard1, card1);
                DealCard2(ref picPlayerCard2, card2);
                DealerDealCard(ref picDealerCard1, card1);
                DealerDealCard2(ref picDealerCard2, card2);
                DealerDealCard3(ref picDealerCard3, card3);
                this.picDealerCard3.Visible = true;
            }
            // call the declareWinner function
            declareWinner();
            totalCardValue[2] = 0;
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            // declare local variables
            int card1 = 0;
            int card2 = 0;
            int card3 = 0;

            // generate yesOrNo
            yesOrNo = randomNumberGenerator.Next(0, 1 + 1);

            // make the 3rd player card visible
            this.picPlayerCard3.Visible = true;
            
            // set the nudBet text to "0"
            this.nudBet.Text = "0";

            // if yesOrNo is 0, set trueOrFalse to false. if not, set it to true
            if (yesOrNo == 0)
            {
                trueOrFalse = false;
            }
            else
            {
                trueOrFalse = true;
            }

            // if trueOrFalse is true, call only 3 player cards and the 2 dealer cards, if not, call the 3 player cards and 3 dealer cards
            if (trueOrFalse == true)
            {
                DealCard(ref picPlayerCard1, card1);
                DealCard2(ref picPlayerCard2, card2);
                DealCard3(ref picPlayerCard3, card3);
                DealerDealCard(ref picDealerCard1, card1);
                DealerDealCard2(ref picDealerCard2, card2);
                this.picDealerCard3.Visible = false;
            }
            else
            {
                DealCard(ref picPlayerCard1, card1);
                DealCard2(ref picPlayerCard2, card2);
                DealCard3(ref picPlayerCard3, card3);
                DealerDealCard(ref picDealerCard1, card1);
                DealerDealCard2(ref picDealerCard2, card2);
                DealerDealCard3(ref picDealerCard3, card3);
                this.picDealerCard3.Visible = true;
            }

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

            // update the labels text
            this.lblPlayerTotal.Text = "Player Card Total: ???";
            this.lblDealerTotal.Text = "Dealer Card Total: ???";
            this.lblBalance.Text = "Your Balance: " + balance + "$";

            // Enable the hit and stay buttons
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;

            // make the maximum of the nudBet to the current balance
            this.nudBet.Maximum = balance;

            // Hide all the labels (win, lose, tie, playerCard3)
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.picPlayerCard3.Visible = false;
            this.btnBet.Enabled = true;
            this.nudBet.Enabled = true;
            this.nudBet.Text = "0";
            this.btnPlay.Enabled = false;
            this.picDealerCard3.Visible = false;
            
            // make the stored balance the current balance (used for later)
            storedBalance = balance;
        }

        private void declareWinner()
        {
            // declare local variables
            int cardTotal;
            int dealerCardTotal;
            
            // math for the total player and total dealer card values
            cardTotal = totalCardValue[0] + totalCardValue[1] + totalCardValue[2];
            dealerCardTotal = totalDealerCardValue[0] + totalDealerCardValue[1] + totalDealerCardValue[2];

            // if trueOrFalse is false, the dealerCard total is all 3 added up, if not, it's only value 1 and 2
            if (trueOrFalse == false)
            {
                dealerCardTotal = totalDealerCardValue[0] + totalDealerCardValue[1] + totalDealerCardValue[2];
            }
            else
            {
                dealerCardTotal = totalDealerCardValue[0] + totalDealerCardValue[1];
            }

            // update the player and dealer card labels
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
                balance = balance + amountBettedOn;
                this.lblBalance.Text = "Your Balance: " + balance + "$";
            }
            else if (cardTotal > 21)
            {
                this.lblYouLose.Visible = true;
                balance = balance - amountBettedOn;
                this.lblBalance.Text = "Your Balance: " + balance + "$";
            }
            else if (cardTotal > dealerCardTotal)
            {
                this.lblYouWin.Visible = true;
                balance = balance + amountBettedOn;
                this.lblBalance.Text = "Your Balance: " + balance + "$";
            }
            else
            {
                this.lblYouLose.Visible = true;
                balance = balance - amountBettedOn;
                this.lblBalance.Text = "Your Balance: " + balance + "$";
            }

            // if the user has no money, a message box will show up saying you have no money and a new game will start
            if (balance <= 0)
            {
                MessageBox.Show("You are broke. Starting a new game!", "Error");
                balance = 100;
                NewDeck();
            }

            // if there is less than 6 pictures in the card deck, a message box will show up saying there is no cards left, and the programm will reshuffle the deck
            if (listOfCardImages.Count() < 6)
            {
                MessageBox.Show("You ran out of cards. Reshuffling deck!", "Error");

                NewDeck();
            }
            // disable buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            this.btnPlay.Enabled = true;
            this.btnBet.Enabled = false;
            this.nudBet.Enabled = false;
            amountBettedOn = 0;
        }

        private void MniNewGame_Click(object sender, EventArgs e)
        {
            // set the balance to 100 and call a new game
            balance = 100;
            NewDeck();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // A message box will show up. if the user clicks "OK", the program closes. If the user clicks CANCEL, the program will keep running.
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Menu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnBet_Click(object sender, EventArgs e)
        {
            // get the amountBetted on from the number up down box
            amountBettedOn = int.Parse(this.nudBet.Text);
            // disable the bet button and number up down
            this.btnBet.Enabled = false;
            this.nudBet.Enabled = false;

            // if you bet nothing, a message box will show up saying "I'll pass on betting this round"
            if (amountBettedOn == 0)
            {
                MessageBox.Show("I'll pass on betting this round", "Your Choice");
            }
            // when the user bets, a message box will show up saying "are you sure you want to bet $?"
            // if the user clicks "OK" the bet system will disable for that round and if they click cancel, the bet system will re enable giving them a chance to bet again
            else if (MessageBox.Show("You are betting " + amountBettedOn + "$ Are you sure?", "Your Choice", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.btnBet.Enabled = false;
                this.nudBet.Enabled = false;
            }
            else
            {
                this.btnBet.Enabled = true;
                this.nudBet.Enabled = true;
            }
        }
    }
}
